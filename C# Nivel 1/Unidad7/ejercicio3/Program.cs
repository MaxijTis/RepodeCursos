using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa que solicite una cadena de caracteres 
            //y dos caracteres sueltos (tres ingresos). El programa deberá generar 
            //una cadena donde todas las ocurrencias del primer carácter dado hayan 
            //sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
            //CADENA FUENTE: “La mar estaba serena"
            //CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            //CADENA RESULTADO: “Li mir estibi sereni"

            char[] cadena = new char[30];
            char cara1;
            char cara2;
            char letra;
            int indice = 0;

            Console.WriteLine("Ingrese su frase letra por letra, no debe superar los 30 caracteres ");
             letra = char.Parse(Console.ReadLine());

            while (letra != '.')
            {
                cadena[indice] = letra;
                letra = char.Parse(Console.ReadLine());

                indice++;
            }

            cadena[indice] = '\0';
            indice = 0;
            Console.WriteLine("La frase actual es: ");
            while (cadena[indice] != '\0')
            {
                Console.Write(cadena[indice]);
            indice++;               
            }
            indice = 0;
            Console.ReadLine();
            Console.WriteLine("Ingrese el valor a reemplazar: ");
            cara1 = char.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el nuevo valor: ");
            cara2 = char.Parse(Console.ReadLine());

             for(int x = 0; x < 30; x++){

            if(cadena[x] == cara1){

                cadena[x] = cara2;
            }

               
                Console.Write(cadena[x]);
             }
             

            




        }
    }
}
