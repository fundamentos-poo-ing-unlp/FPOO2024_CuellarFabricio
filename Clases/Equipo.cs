using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIv2.Clases
{
    public abstract class Equipo(int id, string descripcion)
    {
        // ******* ATRIBUTOS *******
        public List<Via> vias = new List<Via>();
        public double[] totalVehiculosXvia = new double[10];
        // La estructura info contiene información de los pasajes de vehículos registrados por fecha u hora en los archivos .txt o .db, 
        

        public struct info
        {
            public string fecha_txt;
            public DateTime fecha = new();
            public int total;
            public List<int> total_por_via = new List<int>();
            public int Total { get { return total_por_via.Sum(); } }
            public info(string f, int v1, int v2) // Este constructor sirve para los .txt
            {
                fecha_txt = f;
                total_por_via.Add(v1);
                total_por_via.Add(v2);
                total = total_por_via.Sum();
                fecha = DateTime.Parse(fecha_txt, CultureInfo.GetCultureInfo("es-AR"));
            }
            public info(string f, int[] v) // Este constructor sirve para la base de datos.
            {
                fecha_txt = f;
                foreach (int a in v)
                {
                    total_por_via.Add(a);
                }
                total = total_por_via.Sum();
                fecha = DateTime.Parse(fecha_txt, CultureInfo.GetCultureInfo("es-AR"));
            }
        };
        public List<info> list_info_struct = new List<info>();


        // ******* PROPIEDADES *******
        public int ID => id;
        public int CantidadVias => vias.Count;  // Devuelve el número total de vías que el equipo monitorea.
        public string Descripcion {
            get { return descripcion; }
            set { descripcion = value; }
        }

        // // ******* INDEXADORES *******
        public Via this[int i] => vias[i];

        // ******* MÉTODOS *******
        public abstract void AgregarVia(Via v);
        public void QuitarVia(Via v) => vias.Remove(v);
        public void ModificarSentidoVia(int nroCarril)
        {
            Via v = vias.Find(v => v.NumeroCarril == nroCarril);
            Console.WriteLine("Ingresar nuevo sentido: ");
            v.SentidoCirculacion = Console.ReadLine();
        }
        public void ModificarSentidoVia(int nroCarril, string nuevoSentido)
        {
            Via v = vias.Find(v => v.NumeroCarril == nroCarril);
            v.SentidoCirculacion = nuevoSentido;
        }
        public Via GetVia(int nroCarril)
        {
            Via v = vias.Find(v => v.NumeroCarril == nroCarril);
            return v;
        }
        // Concatena e imprime todas el número de carril de todas las vías asociadas al equipo
        public string ImprimirVias()
        {
            string lista_vias = "";
            if (CantidadVias > 0)
            {
                for (int i = 0; i < CantidadVias; i++)
                {
                    lista_vias += this[i].NumeroCarril + ",";
                }
                return lista_vias;
            }
            else
            {
                return "Sin vías";
            }
        }
        public override string ToString()
        {
            return string.Format("Objeto: {0}. Descripción: {1}. Vías asociadas: {2}", GetType().Name, Descripcion, CantidadVias);
        }
        public abstract void InfoRegistros();
    }
}
