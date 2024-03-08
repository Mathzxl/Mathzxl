using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2. Leia um número fornecido pelo usuário. Se esse número for positivo, calcule a raiz quadrada
do número. Se o número for negativo, mostre uma mensagem dizendo que o número é inválido*/
            double n1;
            Console.WriteLine("De o valor de um número qualquer");
            n1 = double.Parse(Console.ReadLine());
            if (n1 > 0)
            {
                n1 = Math.Sqrt(n1);
                Console.WriteLine("O valor da raiz quadrada do número informado é: " + n1);
            }
            else
            {
                Console.WriteLine("O valor informado é invalido");
            }
            Console.ReadLine();
        }
    }
}
