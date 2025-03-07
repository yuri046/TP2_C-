using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Exercicio_8
{
    internal class Ex8
    {
        public static void NotaEscolar()
        {
            Console.WriteLine("Insira uma nota de 0 a 10");
            int nota = int.Parse(Console.ReadLine());

            if(nota >= 0 && nota <= 5)
            {
                Console.WriteLine($"\nNota: {nota}\nNota insuficiente");
            } else if(nota >= 6 && nota <= 7)
            {
                Console.WriteLine($"\nNota: {nota}\nNota regular");
            } else if (nota >= 8 && nota <= 9)
            {
                Console.WriteLine($"\nNota: {nota}\nNota boa");
            } else if( nota == 10 )
            {
                Console.WriteLine($"\nNota: {nota}\nNota excelente");
            } else { Console.WriteLine("Nota inválida"); }
        }
    }
}
