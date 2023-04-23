using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
           //Hacer un programa para solicitar por teclado un número 
           //y luego devolver su valor elevado al cubo.

            int numero, elevado;

            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            elevado = numero * numero * numero;

            Console.WriteLine("El resultado de elevar al cubo es:  " + elevado);

        }
    }
}
