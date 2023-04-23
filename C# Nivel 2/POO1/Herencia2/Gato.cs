using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Gato : AnimalDomestico
    {
        public override string Comunicarse()
        {
            return "miau...miau";
        }
    }
}
