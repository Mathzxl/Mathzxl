using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4. Faça um programa que leia um número e, caso ele seja positivo, calcule e mostre:
• O número digitado ao quadrado
• A raiz quadrada do número digitado*/
            double n1;
            Console.WriteLine("Escreva o valor de um número qualquer");
            n1 = double.Parse(Console.ReadLine());
            if (n1 > 0)
            {
                n1 = Math.Pow(n1, 2);
                Console.WriteLine("O seu número ao quadrado é igual a:" + n1);
                n1 = Math.Sqrt(n1);
                Console.WriteLine("A raiz do seu número é igual a:" + n1);
            }
            else
            {
                Console.WriteLine("O número inserido é negativo, por valor coloque um positivo");
            }
            Console.ReadLine();
        }
    }
}
