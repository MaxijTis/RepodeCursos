using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2 ,num3;
            int resultado1 = 0, resultado2 = 0;

            Console.WriteLine("Ingresa un numero ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa un numero ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa un numero ");
            num3 = int.Parse(Console.ReadLine());

            resultado1 = num1 + num2;
            resultado2 = num2 * num3;
            
            if(resultado1 > resultado2){
                Console.WriteLine("Es mayor");
            }else{
                Console.WriteLine("No es mayor ");
            }
        }
    }
}
