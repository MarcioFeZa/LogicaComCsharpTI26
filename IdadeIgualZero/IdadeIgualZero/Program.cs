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
            int idade, anoDeNasc, contador = 1;


            while (contador > 0)
            {
                Console.WriteLine("Digite a sua idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o ano de nascimento: ");
                anoDeNasc = int.Parse(Console.ReadLine());


                Console.Clear();


                if (idade == 0)
                {
                    Console.WriteLine("Fim do programa, idade 0");
                    break;
                }
            }

        }
    }
}
