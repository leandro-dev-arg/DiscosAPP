using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscosAPP
{
    internal class FormatoEdicion
    {
        public int Id { get; set; }

        public string Edicion { get; set; }

        public override string ToString()
        {
            return Edicion;
        }
    }
}
