using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Exercicio_9
{
    internal class Ex9
    {
        public static void salarioLiquido()
        {
            Console.WriteLine("Digite seu salario bruto anual");
            double salarioBruto = double.Parse(Console.ReadLine());

            int faixa1 = 27000;
            int faixa2 = 36000;
            int faixa3 = 45000;
            int faixa4 = 55000;
            double imposto = 0;
            double salarioLiquido;

            if (salarioBruto <= faixa1)
            {
                salarioLiquido = salarioBruto;
                Console.WriteLine($"Imposto: {imposto} \nSalario bruto: {salarioBruto} \nSalario liquido: {salarioLiquido}");
            } else if (salarioBruto > faixa1 && salarioBruto <= faixa2)
            {
                imposto = salarioBruto * 0.05;
                salarioLiquido = salarioBruto - imposto;
                Console.WriteLine($"Salario bruto: {salarioBruto}\nImposto: {imposto}\nSalario liquido: {salarioLiquido}");
            } else if(salarioBruto > faixa2 && salarioBruto <= faixa3)
            {
                imposto = salarioBruto * 0.10;
                salarioLiquido = salarioBruto - imposto;
                Console.WriteLine($"Salario bruto: {salarioBruto}\nImposto: {imposto}\nSalario liquido: {salarioLiquido}");
            } else if(salarioBruto >= faixa4)
            {
                imposto = salarioBruto * 0.15;
                salarioLiquido = salarioBruto - imposto;
                Console.WriteLine($"Salario bruto: {salarioBruto}\nImposto: {imposto}\nSalario liquido: {salarioLiquido}");
            }
        }
    }
}
