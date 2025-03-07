using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp3.Exercicio_1
{
    internal class Ex1
    {
        public static void CalculaIdade()
        {
            Console.WriteLine("Digite o ano de nascimento:");
            int ano = int.Parse(Console.ReadLine());

            Console.WriteLine("DIgite o mes de nascimento:");
            int mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o dia de nascimento:");
            int dia = int.Parse(Console.ReadLine());

            DateTime dataNascimento = new DateTime(ano, mes, dia);

            DateTime dataAtual = DateTime.Now;

            int anos = dataAtual.Year - dataNascimento.Year;
            int meses = dataAtual.Month - dataNascimento.Month;
            int dias = dataAtual.Day - dataNascimento.Day;

            if(meses < 0)
            {
                --anos;
                meses += 12;
            }

            if (dias < 0) {
                DateTime dataAnterior = dataAtual.AddMonths(-1);
                dias += DateTime.DaysInMonth(dataAnterior.Year, dataAnterior.Month);
            }

            Console.WriteLine($"{anos} anos, {meses} meses e {dias} dias");
        }
    }
}
