using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, mayor = 0;

            Console.WriteLine("Ingrese un numero ");
            n = int.Parse(Console.ReadLine());
            mayor = n;

            for (int X = 0; X < 10; X++){
                Console.WriteLine("Ingrese un numero ");
                n = int.Parse(Console.ReadLine());

                if(n > mayor){
                    mayor = n;
                }
            }

            Console.WriteLine("El mayor numero del ciclo es " + mayor);

        }
    }
}
