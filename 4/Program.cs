using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Diseñar un pseudocódigo que imprima la quinta parte de la suma de 3 números enteros. 

            double num1, num2, num3, suma, quinta;

            Console.WriteLine("Ingresa el primer número");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo número");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el tercer número");
            num3 = double.Parse(Console.ReadLine());

            suma = num1 + num2 + num3;
            quinta = suma / 5;

            Console.WriteLine("La quinta parte de la suma (" + suma + ") es " + quinta);
            Console.ReadKey();
        }
    }
}
