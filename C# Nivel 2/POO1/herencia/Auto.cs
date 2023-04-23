using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{// asociacion(relacion entre clases,) funcionan igual
 // composicion(es un tipo) y agregacion()
    internal class Auto : Vehiculo
    {

        public Auto() 
        {
            Chasis = new Chasis();
        
        }
        public string modelo { get; set; }  
        public int anio { get; set; }    
        public string color { get; set; }

        
        //asociacion se lee como "tiene"....ej "un auto Tiene un motor"
        //composicion (depende el nivel de cercania,si puede nacer la clase sin esa clase)
        //lo compone
        public Chasis Chasis { get; }  


        //agregacion(el motor puede ser agregado luego)
        public Motor motor { get; set; }    
    }
}
