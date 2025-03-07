using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Exercicio_3
{
    internal class Ex3
    {
        public static void DiferencaDatas()
        {

            Console.WriteLine("Digite a primeira data (dd/MM/yyyy):");
            DateTime data1 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.WriteLine("Digite a segunda data (dd/MM/yyyy):");
            DateTime data2 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            int anos = data2.Year - data1.Year;
            int meses = data2.Month - data1.Month;
            int dias = data2.Day - data1.Day;

            if (meses < 0)
            {
                anos--;
                meses += 12; 
            }

            if (dias < 0)
            {
                meses--;
                DateTime dataAnterior = data2.AddMonths(-1);
                dias += DateTime.DaysInMonth(dataAnterior.Year, dataAnterior.Month);
            }

            Console.WriteLine($"A diferença entre as duas datas é de {anos} anos, {meses} meses e {dias} dias.");
        }
    }
}
