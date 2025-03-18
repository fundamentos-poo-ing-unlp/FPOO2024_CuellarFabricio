using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIv2.Clases
{
    public class Estacion(string localidad, double latitud, double longitud)
    {
        // ******* ATRIBUTOS *******
        public List<Equipo> equipos = new List<Equipo>();

        // ******* PROPIEDADES *******
        public string Localidad => localidad;
        public double Longitud => longitud;
        public double Latitud => latitud;
        public int TotalEquipos => equipos.Count;

        // ******* MÉTODOS *******
        public void AgregarEquipo(Equipo e) => equipos.Add(e);
        public void QuitarEquipo(Equipo e) => equipos.Remove(e);
        public Equipo GetEquipo(int id)
        {
            return equipos.Find(e => e.ID == id);
        }

    }
}
