using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
         //1. Hacer un programa para ingresar 10 números. El mismo debe analizar y 
         //mostrar por pantalla cuántos de esos números son primos.

            int n, cont = 0, cont1 = 0;
            int aux = 1;

            for(int x = 0; x < 10; x++){
                Console.WriteLine("Ingresa un numero ");
                n = int.Parse(Console.ReadLine());
                cont = 0;
                aux = 1;

           
                while (aux <= n){
                    if(n % aux == 0){
                    cont++;
                    aux++;
                    }
                    if(cont == 2){
                        cont1++;
                    }
                }
            }

            Console.WriteLine("La cantidad de numeros primos es: " + cont1);

        }
    }
}
