using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Exercicio_6
{
    internal class Ex6
    {
        public static void CalculoImc()
        {
            Console.WriteLine("Digite a sua altura:");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o seu peso:");
            double peso = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura)  ;


            if(imc < 18.5)
            {
                Console.WriteLine($"IMC: {imc}\nVocê está com magreza");
            } else if(imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine($"IMC: {imc}\nSeu peso está normal");
            } else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine($"IMC: {imc}\nVocê está com sobrepeso");
            } else if (imc >= 30 && imc <= 34.9)
            {
                Console.WriteLine($"IMC: {imc}\nVocê está com obesidade grau I");
            } else if (imc >= 35 && imc <= 39.9)
            {
                Console.WriteLine($"IMC: {imc}\nVocê está com obesidade grau II");
            } else
            {
                Console.WriteLine($"IMC: {imc}\nVocê está com obesidade grau III");
            }
        }
    }
}
