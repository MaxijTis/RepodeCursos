using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {


            // 4. Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 
            // más una comisión del 5% sobre el total facturado por cada empleado. 
            // Hacer un programa para ingresar el total facturado por un empleado y 
            // que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.

            float totalFacturado, comision, sueldoFinal;

            Console.WriteLine("Ingrese el total facturado ");
            totalFacturado = float.Parse(Console.ReadLine());
            
            comision = (5 * totalFacturado)/ 100;

            sueldoFinal = comision + 15000;
            Console.WriteLine("El sueldo final a cobrar es  " + sueldoFinal);




        }
    }
}
