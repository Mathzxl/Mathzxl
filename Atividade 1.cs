using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Faça um programa que receba dois números e mostre qual deles é o maior.*/
            double n1, n2;
            Console.WriteLine("Escreva o valor de um numero 1 qualquer");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("EScreva o valor de um numero 2 qualquer");
            n2 = double.Parse(Console.ReadLine());
            if (n1 > n2)
            { Console.WriteLine("O valor do numero 1 e maior que o valor do numero 2"); 
            }
            else if (n2 > n1)
            {
                Console.WriteLine("O valor do numero 2 e maior que o valor de numero 1");
            }
            else
            {
                Console.WriteLine("Os valores inserido são iguais");
            }
            Console.ReadLine();
        }
    }
}
