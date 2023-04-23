using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
           int num;

           Console.WriteLine("Ingresa un numero: ");
           num = int.Parse(Console.ReadLine());

           if(num > 0){
               Console.WriteLine("Positivo");
           }else if(num < 0){
               Console.WriteLine("Negativo");
           }else{
               Console.WriteLine("Cero");
           }
        }
    }
}
