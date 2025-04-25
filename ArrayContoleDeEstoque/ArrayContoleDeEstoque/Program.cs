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

                int[] produtos = new int[50];

                int quantidadeProduto;

                for (int i = 0; i < produtos.Length; i++)
                {
                    Console.WriteLine($"Digite a quantidade em estoque do {i + 1}° Produto: ");
                    quantidadeProduto = int.Parse(Console.ReadLine());
                    produtos[i] = quantidadeProduto;

                }
                int Maior = produtos.Max();
                int Menor = produtos.Min();
                int posicaoMaior = 0;
                int posicaoMenor = 0;

                for (int j = 0; j < produtos.Length; j++)
                {
                    if (produtos[j] == Maior)
                    {
                        posicaoMaior = j;
                    }
                    if (produtos[j] == Menor)
                    {
                        posicaoMenor = j;
                    }
                }

                Console.WriteLine($"O Produto com maior quantidade é o produto {posicaoMaior + 1} Com a quantidade de {Maior} em estoque");
                Console.WriteLine($"O Produto com menor quantidade em estoque  é o produto {posicaoMenor + 1}  Com a quantidade de {Menor} em estoque");
            }


        }
    }



    

