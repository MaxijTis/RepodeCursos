using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int edad;
            //float sueldo;
            //string nombre;

            //int[] edades = new int[10];
            //float[] sueldos = new float[10];
            //string[] nombres = new string[10];

            //Persona p1 = new Persona("Maxi");
            //p1.setEdad(20);

            //Console.WriteLine(p1.saludar());
            //Console.WriteLine("La edad es: " + p1.getEdad());

            Botella b1 = new Botella("rojo", "Plastico");
            Console.WriteLine("Capacidad de la botella: " + b1.Capacidad);
            Console.WriteLine("La capacidad actual es: " +  b1.CantidadActual);

            b1.recargar();
            Console.WriteLine("Luego de recargar, la capacidad actual es: " + b1.CantidadActual);

            //         b1.Capacidad = 200;

            //Botella b2 = new Botella();
            //           int algo = b1.Capacidad;

            //Perro d1 = new Perro();
            //d1.Edad = 4;
            //int algo2 = d1.Edad;

            //Console.WriteLine("La edad es: " + algo);

            Console.ReadKey();


        }
    }
}
