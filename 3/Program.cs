using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diseñar un pseudocódigo que imprima el promedio de 5 notas diferentes.

            double nota1, nota2, nota3, nota4, nota5, promedio;

            Console.WriteLine("Ingresa la primera nota");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la segunda nota");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la tercera nota");
            nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la cuarta nota");
            nota4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la quinta nota");
            nota5 = double.Parse(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

            Console.WriteLine("El promedio es de " + promedio);
            Console.ReadKey();
        }
    }
}
