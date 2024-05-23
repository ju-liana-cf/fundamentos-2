using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diseñar un pseudocódigo que imprima la edad de una persona de acuerdo al año que nació.

            double fechaNa, edad, año;

            Console.WriteLine("Ingresa el año en el que nació");
            fechaNa = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el año actual");
            año = double.Parse(Console.ReadLine());

            edad = año - fechaNa;

            Console.WriteLine("Su edad es de " + edad + " años");
            Console.ReadKey();
        }
    }
}
