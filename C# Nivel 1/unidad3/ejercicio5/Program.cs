using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num1, num2, num3, num4;

        Console.WriteLine("Ingresa un numero ");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingresa un numero ");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingresa un numero ");
        num3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingresa un numero ");
        num4 = int.Parse(Console.ReadLine());

        if(num1 > 100)
            Console.WriteLine(num1);
        if(num2 > 100)
            Console.WriteLine(num2);
        if(num3 > 100)
            Console.WriteLine(num3);
        if(num4 > 100)
            Console.WriteLine(num4);
            

        
        }
    }
}
