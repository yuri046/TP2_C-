using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Exercicio_11
{
    internal class Ex11
    {
        public static void Tabuada()
        {
            Console.WriteLine("Insira um número");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int resultado = num * i;
                Console.WriteLine($"{num} X {i} = {resultado}");
            }
        }
    }
}
