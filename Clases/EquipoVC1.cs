using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TIv2.Clases
{
    public class EquipoVC1 : Equipo
    {
        // ******* ATRIBUTOS *******
        private string rutaTxt;
        private int nroVias = 2;
        public EquipoVC1(int id, string descripcion, string rutaTxt) : base(id, descripcion)
        {
            this.rutaTxt = rutaTxt;
            InfoRegistros();
        }

        // // ******* MÉTODOS *******
        public override void AgregarVia(Via v)
        {
            if (CantidadVias == nroVias)
            {
                MessageBox.Show("Este tipo de equipos supervisa dos vías como máximo.");
                return;
            }
            else vias.Add(v);
        }
        public override void InfoRegistros()
        {
            string fecha;
            string fecha_aux = "0";
            string reg = "";
            string[] partes;
            int via1 = 0;
            int via2 = 0;
            string[] archivos_txt = Directory.GetFiles(rutaTxt);

            string pattern = @"\d{2}/\d{2}/\d{2}";
            Regex regex = new Regex(pattern);

            foreach (string archivo in archivos_txt)
            {
                fecha = "";
                reg = "";
                StreamReader lector = new(archivo);

                // Obtengo la fecha del archivo, tengo que leer las 26 líneas del encabezado. En la 5ta línea se encuentra la fecha del archivo txt.
                for (int j = 1; j < 26; j++)
                {
                    if (j == 5)
                    {
                        fecha = lector.ReadLine();
                        Match match = regex.Match(fecha);
                        fecha = match.Value;
                    }
                    else _ = lector.ReadLine();
                }

                // Cuento los pasajes de vehículos por cada vía. Leo hasta el final del archivo.
                while ((reg = lector.ReadLine()) != null)
                {
                    partes = reg.Split(" ");
                    if (partes[3] == "1") via1++;
                    else via2++;
                }

                if (fecha != fecha_aux)
                {
                    list_info_struct.Add(new info(fecha, via1, via2));
                    fecha_aux = fecha;
                    via1 = 0;
                    via2 = 0;
                } 

                lector.Close();
            }
            foreach (info s in list_info_struct)
            {
                totalVehiculosXvia[0] += s.total_por_via[0];
                totalVehiculosXvia[1] += s.total_por_via[1];
            }            
        }
    }
}
