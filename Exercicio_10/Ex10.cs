using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Exercicio_10
{
    internal class Ex10
    {
        public static void ContagemRegressiva()
        {
            Console.WriteLine("Insira um numero");

            int num = int.Parse(Console.ReadLine());

            for (int i = num; i >= 0; i--)
            {
                if (i == num)
                {
                    Console.Write($"{i}");
                } else
                {
                    Console.Write($", {i}");
                }
                
            }
        }
    }
}
