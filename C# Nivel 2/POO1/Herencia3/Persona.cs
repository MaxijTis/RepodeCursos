using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    abstract class Persona
    {
        //cuando es una clase abstracta impedimos se pueda crear una instancia "persona"
        //clase base generalmente se pone abstracta, te obliga a que heredes
        //seeled: es lo contrario a abstract impide que heredes..marca el final de una Jerarquia
        //static: una clase,no se puede heredary no se puede instanciar,
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Legajo { get; set; }


    }
}
