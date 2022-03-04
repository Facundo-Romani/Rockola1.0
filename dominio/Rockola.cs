using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Rockola
    {
        // Propiedades de la clase Rockola.
        public string Titulo { get; set; }
        public DateTime Fecha { get; set; }
        public int Canciones { get; set; }
        public string Url { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
