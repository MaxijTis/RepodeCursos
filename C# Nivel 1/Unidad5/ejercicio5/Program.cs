using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Hacer un programa que solicite 20 números 
            //y luego emitir por pantalla el máximo de los números pares y 
            //el mínimo de los números impares.
            int n = 0;
            int max = 0, min = 0;

            Console.WriteLine("Ingresa el primer numero ");
            n = int.Parse(Console.ReadLine());
            
            max = n;
            min = n;

            for (int x = 0; x < 19; x++){
                Console.WriteLine("Ingresa un numero..");
                n = int.Parse(Console.ReadLine());

                if(n % 2 == 0){
                    if(max < n){
                    max = n;

                    }
                }else{
                    if(n < min){
                    min = n;

                    }

                }

            }

            Console.WriteLine("El maximo de los pares es: " + max);
            Console.WriteLine("El minimo de los impares es: " + min);
            







        }
    }
}
