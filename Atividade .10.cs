using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1._10
{
    class Program
    {
        static void Main(string[] args)
        {
                       /*10. Faça um programa que receba a altura e o sexo de uma pessoa e calcule e mostre seu peso
ideal, utilizando as seguintes fórmulas (onde h corresponde à altura):
• Homens: (72,7 * h) - 58
• Mulheres: (62, 1 * h) – 44, 7*/
            double A, sx, pi;
            Console.WriteLine("Dê a altura de uma pessoa");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("De o sexo de uma pessoa(H/M)");
            sx = char.Parse(Console.ReadLine());
            if (sx == 'H' || sx == 'h')
            {
                pi = (72.7 * A) - 58;
                Console.WriteLine("O peso ideal do Homem sera de: " + pi);
            }
            else
            {
                pi = (62.1 * A) - 44.7;
                Console.WriteLine("O peso ideal da Mulher séria de: " + pi);
            }
            Console.ReadLine();
        }
    }
}
