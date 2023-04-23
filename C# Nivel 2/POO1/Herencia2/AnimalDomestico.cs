using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class AnimalDomestico : Animal
    {
        public String nombre;

        public override string ToString()
        {
            return "Animal: " + nombre;
        }
    }
}
