using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado, acumulador = 0;


           for (int x = 0; x < 5; x++)
           {
           
           Console.WriteLine("Ingrese un numero ");
           numero = int.Parse(Console.ReadLine());
           resultado = par(numero);
               if(resultado == 1)
               {
                   acumulador++; 
               }
           }

            Console.WriteLine("Son pares " + acumulador + " numeros");
            
        }

        static int par(int n)
        {
            if(n % 2 == 0)
            {
                n = 1;
            }else{ 
                n = 0;
            }

            return n;
        }
    }
}
