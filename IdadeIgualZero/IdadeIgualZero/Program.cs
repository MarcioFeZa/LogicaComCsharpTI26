using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdadeIgualZero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade, anoAtual, anoNascimento, contador = 1;


            while (contador > 0)
            {
                Console.WriteLine("Digite a sua idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o ano atual: ");
                anoAtual = int.Parse(Console.ReadLine());
                anoNascimento = anoAtual - idade;


                Console.Clear();


                if (idade == 0)
                {
                    Console.WriteLine("Fim do programa, idade 0");

                }
                else
                {

                    Console.WriteLine("O Ano de Nascimento é  " + anoNascimento);
            }   }

        }
    }
}
