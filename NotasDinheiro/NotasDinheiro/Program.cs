using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasDinheiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor;

            Console.WriteLine("Digite o valor para ser trocado: ");
            valor = int.Parse(Console.ReadLine());

            if(valor >= 100)
            {
                Console.WriteLine(" 1 nota de R$100 ");
                valor = valor - 100;
            }
            if(valor >= 50)
            {
                Console.WriteLine(" 1  nota de R$50 ");
                valor = valor - 50;
            }
            if(valor >= 20)
            {
                Console.WriteLine(" 1 nota de R$20 ");
                valor = valor - 20;
            }
            if(valor >= 10)
            {
                Console.WriteLine(" 1 nota de R$10 ");
                valor = valor - 10;
            }
            if(valor >= 5)
            {
                Console.WriteLine(" 1 nota de R$5 ");
                valor = valor - 5;
            }
            if (valor >= 4)
            {
                Console.WriteLine(" 2 nota de R$2 ");
                valor = valor - 4;
            }
            if (valor >= 2)
            {
                Console.WriteLine(" 1 nota de R$2 ");
                valor = valor - 2;
            }



        }
    }
}
