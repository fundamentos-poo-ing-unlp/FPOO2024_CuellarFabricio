using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIv2.Clases
{
    public class Via(int nroCarril, string sentidoCirculacion)
    {
        // ATRIBUTOS
        private int nroCarril = nroCarril;
        private string sentidoCirculacion = sentidoCirculacion;

        // PROPIEDADES
        public int NumeroCarril { set { nroCarril = value; } get { return nroCarril; } }
        public string SentidoCirculacion { get { return sentidoCirculacion; } set { sentidoCirculacion = value; } }

        // MÉTODOS
        public override string ToString()
        {
            return string.Format("Nro. carril: {0}. Sentido de circulación: {1}.", NumeroCarril, sentidoCirculacion);
        }
    }
}
