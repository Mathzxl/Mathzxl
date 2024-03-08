using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*7. Faça um programa que receba dois números e mostre o maior. Se por acaso, os dois números
forem iguais, imprima a mensagem Números iguais.*/
            double n1, n2;
            Console.WriteLine("de o valor de um número");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("de o valor de outro número");
            n2 = double.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                Console.WriteLine("\nO valor do primeiro número é maior que o valor do segundo número: " + n1);
            }
            else if (n2 > n1)
            {
                Console.WriteLine("\nO valor do segundo número é maior que o valor do primeiro número: " + n2);
            }
            else
            {
                Console.WriteLine("\nOs dois números informados são iguais: " + n1 +(",") + n2);
            }
            Console.ReadLine();
        }
    }
}
