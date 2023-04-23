using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int posicion = 0, valorMax;

            int[] numeros = new int[10];

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese los valores  ");
                numeros[x] = int.Parse(Console.ReadLine());

            }

            valorMax = numeros[0]; 
            posicion = 1;
            for (int x = 0; x < 10; x++){

                if(valorMax < numeros[x]){
                    valorMax = numeros[x];
                    posicion = x +1;
                }

            }          

            Console.WriteLine("El valor maximo es " + valorMax);
            Console.WriteLine("La posicision en la que se encontro fue: " + posicion);
        }
    }
}
