using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Ingresa un numero: ");
            numero = int.Parse(Console.ReadLine());

            if(numero > 10){
                Console.WriteLine("Es mayor a 10 ");
            }else if(numero == 10){
                Console.WriteLine("Es igual a 10");
            }else{
                Console.WriteLine("Es menor a 10");


            }
        }
    }
}
