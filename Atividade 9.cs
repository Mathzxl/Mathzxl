using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*9.Leia o salário de um trabalhador e o valor da prestação de um empréstimo.Se a prestação for
maior que 20 % do salário imprima: Empréstimo não concedido, caso contrário imprima:
            Empréstimo concedido.*/
            double st, vpe, emp;
            Console.WriteLine("Informe o suposto salário de um trabalhador");
            st = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o suposto valor da prestação de um empréstimo");
            vpe = double.Parse(Console.ReadLine());
            emp = st / 100 * 20;
            if (vpe > emp)
            {
                Console.WriteLine("\nEmprestimo não concedido, o valor das prestações e superio à 20% do salário");
            }
            else
            {
                Console.WriteLine("\nEmprestimo concedido");
            }
            Console.ReadLine();
        }
    }
}
