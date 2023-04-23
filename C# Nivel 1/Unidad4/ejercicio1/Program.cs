using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int resultado = 0;
            Console.WriteLine("Ingresa un valor");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo valor ");
            num2 = int.Parse(Console.ReadLine());
   
        
            if(num1 > num2)
                resultado = num1 - num2;
            

            if(num1 == num2)
                resultado = num1 + num2;
            

            if(num1 < num2)
                resultado = num1 * num2;

            Console.WriteLine("El resultado es " + resultado);
        }
     }
}