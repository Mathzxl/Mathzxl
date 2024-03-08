using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*5. Faça um programa que receba um número inteiro e verifique se este número é par ou ímpar.*/
            double n1;
            Console.WriteLine("Informe o valor de um número inteiro");
            n1 = double.Parse(Console.ReadLine());
            if (n1 % 2 == 0)
            {
                Console.WriteLine("\nO número informado é par: ");
            }
            else
            {
                Console.WriteLine("\nO número informado é ímpar: ");
            }
            Console.ReadLine();
        }
    }
}
