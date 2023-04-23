using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 ,n2;


            Console.WriteLine("Ingrese un numero ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro valor ");
            n2 = int.Parse(Console.ReadLine());

            positivoNegativoCero(n1, ref n2);

            Console.WriteLine(n2);
            
        }

        static void positivoNegativoCero(int a ,ref int b)
        {
            if (a > 0)
              b = 1;
            if(a < 0)
              b = - 1;
            if(a == 0)
              b = 0;

        }
    }
}
