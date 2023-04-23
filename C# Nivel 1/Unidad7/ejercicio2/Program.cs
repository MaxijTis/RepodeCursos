using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vec = new int[10];


            for (int x = 0; x < 10; x++)
            {
            Console.WriteLine("Ingrese un numero");
            vec[x] = int.Parse(Console.ReadLine());
            }

            int promedio;
            int acu = 0;

            for(int x = 0; x < 10; x++){
                acu += vec[x];
            }
                promedio = acu / 10;
                Console.WriteLine("El promedio es " + promedio);


            for(int x = 0; x < 10; x++){

               if(promedio < vec[x]){
               Console.WriteLine("Este elemento fue mayor al promedio " + vec[x]); 
               }
            }
        }
    }
}
