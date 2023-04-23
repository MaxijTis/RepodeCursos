using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Botella
    {

        //Constructor
        public Botella(string color, string material) 
        {
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantidadActual = 0;
        }
         
        //siguiente metodo sobrecargar el constructor. hacemos el mismo construtor
        //con distintas caracteristicas

        public Botella() { }

        //ahora vamos a crear un destructor
        //virgulilla se hace Alt 126
       ~Botella()
        {
            //la logica pra que se ejecute

        }



        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;
        public string Material //si solo quiero devolver el valor
        {
            get { return material; }
        }

        public int CantidadActual
        {
            get { return cantidadActual; }
        }


        public int Capacidad
        {
            get { return capacidad; }
        }
        
    
    //property
        //public int Capacidad
        //{
        //    get { return capacidad; }
        //    set { capacidad = value; }  
        //}

        //metodo
        public float recargar() 
        {
            if (cantidadActual > 0)
            {
                int diff = 100 - cantidadActual;
                float monto = diff * 50 / 100;
                cantidadActual += diff; 
                return monto;           
            }
            cantidadActual = 100;
            return 50;
        }
        public float recargar(int cantidad)
        {
            cantidadActual += cantidad;
            return cantidad * 50 / 100;
        }
    }
}
