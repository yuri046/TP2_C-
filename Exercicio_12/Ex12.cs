using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Exercicio_12
{
    internal class Ex12
    {
        public static void Adivinhacao()
        {
            Console.WriteLine("Insira um numero");
            int num = int.Parse(Console.ReadLine());

            Random random = new Random();
            int numeroAleatorio = random.Next(100);
            Console.WriteLine(numeroAleatorio);

            while (num != numeroAleatorio)
            {
                if (num < numeroAleatorio)
                {
                    Console.WriteLine("O número inserido é menor que o número correto");
                    Console.WriteLine("Tente novamente");
                    num = int.Parse(Console.ReadLine());
                }
                else if (num > numeroAleatorio)
                {
                    Console.WriteLine("O número inserido é maior que o número correto");
                    Console.WriteLine("Tente novamente");
                    num = int.Parse(Console.ReadLine());
                }
               
                if(num == numeroAleatorio)
                {
                    Console.WriteLine($"Você adivinhou o numero\nNúmero secreto: {numeroAleatorio}\nNúmero inserido: {num}");
                }
            }
        }
    }
}
