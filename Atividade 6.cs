using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*6. Escreva um programa que, dados dois números inteiros, mostre na tela o maior deles, assim
como a diferença existente entre ambos.*/
            double n1, n2, d3;
            Console.WriteLine("Infome o valor de um número inteiro");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de outro número inteiro");
            n2 = double.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                Console.WriteLine("\nO valor do primeiro número informado é maior que o valor do segundo número: " + n1);
                d3 = n1 - n2;
                Console.WriteLine("\nA diferença entre os números informados é: " + d3);
            }
            else
            {
                Console.WriteLine("\nO valor do segundo número informado é maior que o valor do primeiro número: " + n2);
                d3 = n2 - n1;
                Console.WriteLine("\nA diferença entre os números informados é: " + d3);
            }
            Console.ReadLine();
        }
    }
}
