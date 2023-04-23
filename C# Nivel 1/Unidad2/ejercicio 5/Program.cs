using System;

namespace ejercicio2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, prom;

            Console.WriteLine("Ingrese la primer nota: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la segunda nota: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la tercer nota: ");
            n3 = int.Parse(Console.ReadLine());

            prom = (n1 + n2 + n3)/3;

            Console.WriteLine("El promedio del alumno es: " + prom);





        }
    }
}
