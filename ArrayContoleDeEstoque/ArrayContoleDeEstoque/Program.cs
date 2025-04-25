using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayContoleDeEstoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Controle de estoque:
            //"Implemente um sistema que armazene a quantidade de 50 produtos em estoque e informe
            //o produto com maior e menor quantidade disponível."

            string[] produto = new string[50];
            int[] quantidade = new int[50];
            int[] estoque = new int[50];    

            for (int i = 0; i < 50; i++)

            {

                Console.WriteLine($"Digite o nome do produto: {i + 1}: ");

                int quantidade = int.Parse(Console.ReadLine());
                estoque($"Produto_{i}", quantidade);

            }

            
        }
    }

}

    

