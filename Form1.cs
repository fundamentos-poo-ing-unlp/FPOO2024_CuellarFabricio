using System.Data;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using ScottPlot;
using TIv2.Clases;
using TIv2.SubForms;

namespace TIv2
{
    public partial class Form1 : Form
    {
        private Estacion estacion;
        private int id_equipo = 0;
        private DataTable dataTable = new();
        private DataTable dataTableVias = new();
        private int id_equipo_seleccionado = 0;
        private int id_via_seleccionada = 0;
        private struct aux
        { 
            public int via;
            public Equipo q;
            public aux(int v, Equipo q)
            {
                this.via = v;
                this.q = q;
            }
        };
        private Dictionary<int, aux> dviaEquipo = new();
        
        public Form1()
        {
            InitializeComponent();
            initMap();
            initDatatable();
        }
        // Inicializo mapa
        private void initMap(double lat = -34.92145, double lng = -57.95453)
        {
            gMapControl1.Overlays.Clear();
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(lat, lng);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 15;
            gMapControl1.Zoom = 12;

            GMapOverlay markerOverlay = new("Marcador");
            GMarkerGoogle marker = new(gMapControl1.Position, GMarkerGoogleType.red_dot);
            markerOverlay.Markers.Add(marker);
            gMapControl1.Overlays.Add(markerOverlay);

            gMapControl1.Refresh();
        }
        // Inicializo las tablas de equipos y vías.
        private void initDatatable()
        {
            dataTable.Columns.Add(new DataColumn("ID", typeof(int)));
            dataTable.Columns.Add(new DataColumn("Descripcion", typeof(string)));
            dataTable.Rows.Add();
            dataGridView1.DataSource = dataTable;
            dataGridView1.Enabled = false;

            dataTableVias.Columns.Add(new DataColumn("Nro.", typeof(int)));
            dataTableVias.Columns.Add(new DataColumn("Sentido de circulación", typeof(string)));
            dataTableVias.Columns.Add(new DataColumn("Total vehículos", typeof(int)));
            dataTableVias.Columns.Add(new DataColumn("ID equipo", typeof(string)));
            dataTableVias.Rows.Add();

            dataGridView2.Enabled = false;
            dataGridView2.DataSource = dataTableVias;

        }
        private void ClickEnMarcador(GMapMarker item, MouseEventArgs e)
        {
            if (estacion != null)
            {
                MessageBox.Show("Estación.\n\tLocalidad: " + estacion.Localidad + "\n\tCoordenadas: " + estacion.Latitud + " , " + estacion.Longitud + "\n" + "Equipos administrados: " + estacion.TotalEquipos, "Aviso");
            }
            else
            {
                MessageBox.Show("No hay una estación cargada.", "Advertencia");
            }

        }
        private void ActualizarDataTable()
        {
            int i = 0;
            dataTable.Rows.Clear();
            dataTableVias.Rows.Clear();
            foreach (Equipo q in estacion.equipos)
            {
                dataTable.Rows.Add(q.ID, q.Descripcion);
                foreach (Via v in q.vias)
                {
                    i++;
                    dataTableVias.Rows.Add(i, v.SentidoCirculacion, q.totalVehiculosXvia[v.NumeroCarril - 1], q.ID);
                }
            }
        }
        // Agrego una nueva estación.
        private void nuevaEstaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Si ya existe una estación, se chequea si se quiere sobreescribir
            if (e != null)
            {
                DialogResult res = MessageBox.Show("Perderá la estación actual. ¿Crear nueva?",
                                    "Administrador de estaciones",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
                if (res == DialogResult.No)
                {
                    return;
                }
            }
            FormNuevaEstacion f_est = new();
            f_est.ShowDialog();
            if (f_est.Localidad != null && f_est.Longitud != null && f_est.Latitud != null)
            {
                estacion = new Estacion(f_est.Localidad, f_est.Longitud, f_est.Latitud);
                MessageBox.Show("Nueva estación creada.\n\tLocalidad: " + estacion.Localidad + "\n\tCoordenadas: " + estacion.Latitud + " , " + estacion.Longitud, "Aviso");
                initMap(estacion.Latitud, estacion.Longitud);

                estacion.equipos.Clear();
                id_equipo = 0;
                ActualizarDataTable();
                id_equipo_seleccionado = 0;
                id_via_seleccionada = 0;
                dviaEquipo.Clear();
                formsPlot1.Plot.Clear();
                formsPlot1.Plot.Legend.ManualItems.Clear();
            }
            else
            {
                MessageBox.Show("No se ingresaron los datos necesario para crear la estación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void button_agregarEquipo_Click(object sender, EventArgs e)
        {
            FormNuevoEquipo f_eq = new();
            f_eq.ShowDialog();
            if (f_eq.TipoEquipo != null && f_eq.Ruta != null && f_eq.Descripcion != null)
            {
                if (f_eq.TipoEquipo == "Equipo VC")
                {
                    try
                    {
                        estacion.AgregarEquipo(new EquipoVC1(id_equipo, f_eq.Descripcion, f_eq.Ruta));
                        dataGridView1.Enabled = true;
                        id_equipo++;
                    }
                    catch (DirectoryNotFoundException)
                    {
                        MessageBox.Show("No se pudo crear el equipo...");
                        return;
                    }
                }
                else
                {
                    estacion.AgregarEquipo(new EquipoVR(++id_equipo, f_eq.Descripcion, f_eq.Ruta));
                    dataGridView1.Enabled = true;
                }
                ActualizarDataTable();
                MessageBox.Show("Equipo agregado.", "Aviso");
            }
            else
            {
                MessageBox.Show("No se ingresaron los datos necesario para agregar un nuevo equipo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void button_eliminarEquipo_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Está seguro de eliminar el equipo?",
                                    "Administrador de estaciones",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                return;
            }

            var key = (from s in dviaEquipo
                        where s.Value.q == estacion.GetEquipo(id_equipo_seleccionado)
                        select s.Key).ToList();

            foreach (var k in key)
            {
                dviaEquipo.Remove(k);
            }

            estacion.QuitarEquipo(estacion.GetEquipo(id_equipo_seleccionado));
            ActualizarDataTable();

        }
        // Selecciono la celda sobre la que hice click.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                id_equipo_seleccionado = (int)dataGridView1.Rows[e.RowIndex].Cells["ID"].Value;
            else return;
        }
        private void button_editarEquipo_Click(object sender, EventArgs e)
        {
            FormEditarEquipo f_edq = new();
            f_edq.ShowDialog();
            if (f_edq.Descripcion != null)
            {
                estacion.GetEquipo(id_equipo_seleccionado).Descripcion = f_edq.Descripcion;
                ActualizarDataTable();
            }
            else
            {
                MessageBox.Show("No se ingresaron los datos necesario para agregar un nuevo equipo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        // Bóton para agregar vías.
        private void button6_Click(object sender, EventArgs e)
        {
            FormNuevaVia f_via = new();
            f_via.ShowDialog();
            if (f_via.Numero != null && f_via.Sentido != null && f_via.ID_equipo != null)
            {     
                Equipo q = estacion.GetEquipo(f_via.ID_equipo);
                Via v = new(q.CantidadVias + 1, f_via.Sentido);
                q.AgregarVia(v);
                try
                {
                    dviaEquipo.Add(f_via.Numero, new aux(q.CantidadVias, q));
                }
                catch (System.ArgumentException)
                {
                    MessageBox.Show("Ya se agregó esta vía.");
                }                
                dataGridView2.Enabled = true;
                ActualizarDataTable();
            }
            else
            {
                MessageBox.Show("No se ingresaron los datos necesario para agregar un nuevo equipo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id_equipo_seleccionado = (int)dataGridView1.Rows[e.RowIndex].Cells["ID"].Value;
                FormEditVia f_edv = new(estacion.GetEquipo(id_equipo_seleccionado));
                f_edv.ShowDialog();
                ActualizarDataTable();
            }
            else return;

        }
        // Histograma diario por vía.
        private void button1_Click(object sender, EventArgs e)
        {
            plotHistogramaTotal(dviaEquipo[id_via_seleccionada].via, dviaEquipo[id_via_seleccionada].q.list_info_struct);
        }
        public void plotHistogramaTotal(int v, List<Equipo.info> info)
        {
            formsPlot1.Plot.Clear();
            formsPlot1.Plot.Legend.ManualItems.Clear();
            ScottPlot.Palettes.Category10 palette = new();
            int l = info.Count;

            if (info != null)
            {
                Bar[] bars = new Bar[l];
                Tick[] ticks = new Tick[l];
                for (int i = 0; i < l; i++)
                {
                    bars[i] = new Bar();
                    bars[i].Size = 1;
                    bars[i].Position = i;
                    bars[i].Value = info[i].total_por_via[v - 1];
                    bars[i].FillColor = palette.GetColor(0);
                    ticks[i] = new Tick(i, info[i].fecha_txt);
                }

                formsPlot1.Plot.Add.Bars(bars);
                formsPlot1.Plot.Axes.Margins(bottom: 0);
                formsPlot1.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
                formsPlot1.Plot.Axes.Bottom.TickLabelStyle.Alignment = Alignment.MiddleRight;
                formsPlot1.Plot.Axes.Bottom.MajorTickStyle.Length = 0;
                formsPlot1.Plot.Legend.IsVisible = true;
                formsPlot1.Plot.Legend.Alignment = Alignment.UpperLeft;
                formsPlot1.Plot.Legend.ManualItems.Add(new() { LabelText = "Via " + v, FillColor = palette.GetColor(0) });

                formsPlot1.Refresh();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id_via_seleccionada = (int)dataGridView2.Rows[e.RowIndex].Cells["Nro."].Value;
                button1.Enabled = true;
                button2.Enabled = true;
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
            else return;
        }
        // Histograma por rango de fechas.
        private void button2_Click(object sender, EventArgs e)
        {
            DateTime f1 = dateTimePicker1.Value.Date;
            DateTime f2 = dateTimePicker2.Value.Date;
            if (f1 == f2)
            {
                MessageBox.Show("Seleccione fechas distintas.");
                return;
            }
            else
            {
                DateTime[] fechas = new DateTime[2];
                if (f1 < f2)
                {
                    fechas[0] = f1;
                    fechas[1] = f2;
                }
                else
                {
                    fechas[0] = f2;
                    fechas[1] = f1;
                }

                var list = (from s in dviaEquipo[id_via_seleccionada].q.list_info_struct
                            where s.fecha <= fechas[1] && s.fecha >= fechas[0]
                            select s).ToList();

                plotHistogramaTotal(dviaEquipo[id_via_seleccionada].via, list);
            }
        }
    }
}
