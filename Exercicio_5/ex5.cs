using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Exercicio_5
{
    internal class Ex5
    {
        public static void ConversorTemperatura()
        {
            Console.WriteLine("Digite um valor em graus:");
            double C = double.Parse(Console.ReadLine());

            double F = (C * 9 / 5 ) + 32;
            double K = C + 273.15;

            Console.WriteLine($"Temperatura em: \n\nGraus: {C} \nFahreinheit: {F} \nKelvin: {K}");
        }
    }
}
