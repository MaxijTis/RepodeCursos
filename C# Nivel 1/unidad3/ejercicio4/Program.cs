using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, menor1;
            

            Console.WriteLine("Ingresa un numero ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa un numero ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa un numero ");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa un numero ");
            num4 = int.Parse(Console.ReadLine());
            
            
            if(num1 < num2){
                menor1 = num1;
            }else{
                menor1 = num2;  
            }
            
            if(num3 < menor1){
                menor1 = num3;
            }
            if(num4 < menor1){
                menor1 = num4;  
            }


            Console.WriteLine("el menor es: " + menor1);

        }
    }
}
