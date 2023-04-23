using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Persona
    {
        //edad, sueldo, nombre
        //abajo son los attributos
        //private int edad;
        private float sueldo;
        private string nombre;

        public int edad { get; set; }
        public Persona(string nombre) 
        {
            this.nombre = nombre;
        }

        public void setEdad(int e) 
        {
            edad = e;
        }

        public int getEdad() 
        { 
            return edad;
        }

        //metodos

        public string saludar() 
        {
            return ("hola buenos dias... " + nombre);

        }
    }
}
