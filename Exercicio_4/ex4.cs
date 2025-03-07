using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Exercicio_4
{

    public class Exercicio4
    {
        public static void FormularioCadastro()
        {
            Console.WriteLine("Digite o seu nome: ");
            String nome = Console.ReadLine();

            Console.WriteLine("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu telefone: ");
            long telefone = long.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu e-mail: ");
            String email = Console.ReadLine();

            Console.WriteLine($"Nome: {nome} \nIdade: {idade} \nTelefone: {telefone} \nE-mail: {email}");

        }


    }
}
