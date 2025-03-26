using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CalculoDeIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int ano_nascimento, ano_atual, idade;

            Console.Write("Digite o ano de seu nascimento: ");  //Console.Write = escreva no portugol
            ano_nascimento = int.Parse(Console.ReadLine());     //int.Parse = converte texto em número
            Console.Write("Digite o ano atual: ");
            ano_atual = int.Parse(Console.ReadLine());
            idade = ano_atual - ano_nascimento;
            Console.Write("sua idade é: " + idade + " anos");



        }
    }
}
