using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Exercicio_7
{
    internal class Ex7
    {
        public static void ParImpar()
        {
            Console.WriteLine("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} é par");
            }
            else
            {
                Console.WriteLine($"{num} é ímpar");
            }
        }
    }
}
