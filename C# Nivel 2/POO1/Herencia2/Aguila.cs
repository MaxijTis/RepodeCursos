using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Aguila : AnimalSalvaje, flyable
    {
        public string volar()
        {
            return "Puede volar como un aguila";
        }

    }
}
