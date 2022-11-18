using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo
{
    class Persona
    {
        internal String rut {get;set;}
        internal String nombre { get; set; }
        internal String fono { get; set; }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}", nombre, rut , fono);
        }

    }
}
