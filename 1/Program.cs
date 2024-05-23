using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diseñar un pseudocódigo que convierta una cantidad de metros a centímetros

            double metros, centimetros;

            Console.WriteLine("Ingrese la cantidad en metros");
            metros = double.Parse(Console.ReadLine());

            centimetros = metros * 100;

            Console.WriteLine(metros + " metros a centímetros es " + centimetros);
            Console.ReadKey();
        }
    }
}
