using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diseñar un pseudocódigo para imprimir la suma de tres números enteros.

            double num1, num2, num3, suma;

            Console.WriteLine("Ingresar el primer número");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar el segundo número");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar el tercer número");
            num3 = double.Parse(Console.ReadLine());

            suma = num1 + num2 + num3;

            Console.WriteLine("La suma de los tres números es " + suma);
            Console.ReadKey();
        }
    }
}
