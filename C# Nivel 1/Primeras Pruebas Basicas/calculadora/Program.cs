using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // paso 0 declarar 2 variables (int enteros float numeros con coma) 
            //paso 1 pedir valores
            // paso 2 realizar calculo
            // paso 3 emitir resultado

            int n1, n2, operacion;
            int resultado = 0;

            Console.WriteLine("Ingrese el numero de la operacion que desa realizar");
            Console.WriteLine("1-suma 2-resta 3-multiplicacion 4-division");
            operacion = int.Parse(Console.ReadLine());
            if (operacion == 1 || operacion == 2 || operacion == 3 || operacion == 4 )
            {
                Console.WriteLine("Ingrese un numero: ");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el 2do valor: ");
                n2 = int.Parse(Console.ReadLine());

                switch (operacion)
                    {
                    case 1:
                    resultado = n1 + n2;
                    break;
                    case 2:
                    resultado = n1 - n2;
                    break;
                    case 3:
                    resultado = n1 * n2;
                    break;
                    case 4:
                    resultado = n1 / n2;
                    break;    
                    }
            }
            else
                Console.WriteLine("Opcion Incorrecta...vuelva a intentarlo");
            
            if (resultado != 0)
                Console.WriteLine("El resultado es " + resultado);
        }
    }
}
