using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Exercicio_2
{
    internal class Ex2
    {
        public static void DiasAteAniversario()
        {
            Console.WriteLine("Digite sua data de nascimento (dd/MM/yyyy):");
            DateTime dataNascimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            DateTime dataAtual = DateTime.Today;

            DateTime proximoAniversario = new DateTime(dataAtual.Year, dataNascimento.Month, dataNascimento.Day);

            if (proximoAniversario < dataAtual)
            {
                proximoAniversario = proximoAniversario.AddYears(1);
            }

            TimeSpan diferenca = proximoAniversario - dataAtual;

            Console.WriteLine($"Faltam {diferenca.Days} dias para o seu próximo aniversário.");
        }
    }
    }

