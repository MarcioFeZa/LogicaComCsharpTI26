using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculeDesconto
{
    internal class Program
    {
        static void Main(string[] args)
        {//Um produto com preço acima de 100 reais tem um desconto de 10%. Caso contrário, 
         //o desconto é de 5%. Dado o preço, calcule o valor do desconto.
            double precoProduto, descontoPreco;

            Console.WriteLine("Digite o preço do produto: ");
            precoProduto = double.Parse(Console.ReadLine());

            if(precoProduto > 100)
            {
                descontoPreco = precoProduto * 0.10;

                Console.WriteLine(descontoPreco + " reais de desconto ");
            }
            else
            {
                descontoPreco = precoProduto * 0.05;

                Console.WriteLine(descontoPreco + " reais de desconto ");
            }



        }
    }
}
