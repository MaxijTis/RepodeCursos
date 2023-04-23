using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //de mayor a menor
            int num1, num2, num3, num4;

            Console.WriteLine("Ingresa un valor ");
            num1 = int.Parse(Console.ReadLine());
             Console.WriteLine("Ingresa un valor ");
            num2 = int.Parse(Console.ReadLine());
             Console.WriteLine("Ingresa un valor ");
            num3 = int.Parse(Console.ReadLine());
             Console.WriteLine("Ingresa un valor ");
            num4 = int.Parse(Console.ReadLine());

            if(num1 > num2 && num2 > num3 && num3 > num4){
                Console.WriteLine("EStan ordenados");
            }else{
                Console.WriteLine("No estan ordenados");
            }

        }
    }
}
