using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que permita ingresar los kilómetros existentes 
            //entre dos ciudades y la velocidad promedio de un vehículo. Calcular 
            //y emitir por pantalla el tiempo aproximado que demandará llegar de un punto
            // a otro teniendo en cuenta los datos ingresados.

            float km, velocidad, tiempo;

            Console.WriteLine("ingrese la distancia ");
            km = float.Parse(Console.ReadLine());

            Console.WriteLine("ingrese a que velocidad conduciria ");
            velocidad = float.Parse(Console.ReadLine());

            tiempo = km/velocidad;

            Console.WriteLine("El tiempo estimado de viaje es " + tiempo);




        }
    }
}
