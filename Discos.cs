using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscosAPP
{
    internal class Discos
    {
        public string Titulo { get; set; }

        public DateTime Lanzamiento { get; set; }

        public int Canciones { get; set; }

        public string UrlImagen { get; set; }

        public  Genero Genero { get; set; }
    }
}
