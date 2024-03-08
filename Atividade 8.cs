using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*8. Faça um programa que leia 2 notas de um aluno, verifique se as notas são válidas e exiba na
tela a média destas notas. Uma nota válida deve ser, obrigatoriamente, um valor entre 0.0 e
10.0, onde caso a nota não possua um valor válido, este fato deve ser informado ao usuário e o
programa termina.*/
            double n1, n2, mn;
            Console.WriteLine("Insira uma suposta nota de um aluno");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira uma outra suposta nota de um aluno");
            n2 = double.Parse(Console.ReadLine());
            if (n1 > 0 && n2 > 0 && n1 < 11 && n2 < 11)
            {
                mn = (n1 + n2) / 2;
                Console.WriteLine("\nA media das notas desse aluno é igual a: " + mn);
            }
            else
            {
                Console.WriteLine("\nAlguma das notas possui um valor inválido um valor menor que 0 e maior que 10");
            }
            Console.ReadLine();
        } 
    }
}
