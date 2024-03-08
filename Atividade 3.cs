using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3. Leia um número real. Se o número for positivo imprima a raiz quadrada. Do contrário, imprima
o número ao quadrado.*/
            double n1;
            Console.WriteLine("De o valor de um número real");
            n1 = double.Parse(Console.ReadLine());
            if (n1 > 0)
            {
                n1 = Math.Sqrt(n1);
                Console.WriteLine("A raiz quadrada do seu número é: " + n1);
            }
            else
            {
                n1 = Math.Pow(n1, 2);
                Console.WriteLine("O seu número ao quadrado é igual a: " + n1);
            }
            Console.ReadLine();
        }
    }
}
