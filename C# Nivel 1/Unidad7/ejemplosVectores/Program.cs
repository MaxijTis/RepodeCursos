using System;

namespace ejemplosVectores
{
    class Program
    {
        static void Main(string[] args)
        {
            //se hace vector int[] dias = new int[10];
            //int = enteros, Float = con coma; bool = verdadero o falso
            //char = una letra

            char[] nombre = new char[10];

            char letra;
            int indice = 0;

            Console.WriteLine("Ingrese letra por letra  ");
            letra = char.Parse(Console.ReadLine());

            while(letra != '.' && indice < 10)
            {
                nombre[indice] = letra;
                letra = char.Parse(Console.ReadLine());
                indice++;
            }

            if(indice == 10)
            indice--;

            nombre[indice] = '\0';
            indice = 0;

            Console.Write("Hola ");

            while(nombre[indice] != '\0'){

            Console.Write(nombre[indice]);
            indice++;
            }
        }
    }
}
