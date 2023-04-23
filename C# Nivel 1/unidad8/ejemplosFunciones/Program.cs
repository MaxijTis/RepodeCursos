using System;

namespace ejemplosFunciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0;
            int resultado;
            
            pedirDatos (ref n1, ref n2);

            resultado = sumar(n1 , n2);
            
            Console.WriteLine("El resultado es " + resultado);

            //esto en esata zona se llama Scope o ambito del programa

             //por referencia se pasa poniendo REF, le mandas la ubicacion en memoria y
             // puede modificarse dentro de la funcion
             //y esta se ejecuta tomando lo que vos le das, es una copia
             //pasar el parametro por valor das un valor a la funcion 

        }

        static int sumar( int a, int b){
            int r;
            r = a + b;
            a = 9999;
            return r;
        }

        static void pedirDatos(ref int j, ref int h){
            Console.WriteLine("Ingrese un numero: ");
            j = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el 2do valor: ");
            h = int.Parse(Console.ReadLine()); 
        }
    }
}
