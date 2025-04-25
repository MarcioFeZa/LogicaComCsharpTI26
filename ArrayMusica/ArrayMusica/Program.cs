using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMusica
{
        internal class Program
        {
            static void Main(string[] args)
            {
                // Solicitar o nome do álbum
                Console.Write("Digite o nome do álbum: ");
                string nomeAlbum = Console.ReadLine();

                // Solicitar a quantidade de músicas do álbum
                Console.Write("Digite a quantidade de músicas do álbum: ");
                int quantidadeMusicas = int.Parse(Console.ReadLine());

                // Criar um array para armazenar os nomes das músicas
                string[] musicas = new string[quantidadeMusicas];

                // Loop para cadastrar as músicas
                for (int i = 0; i < quantidadeMusicas; i++)
                {
                    Console.Write($"Digite o nome da música {i + 1}: ");
                    musicas[i] = Console.ReadLine();
                }

                // Exibir o nome do álbum e as músicas cadastradas
                Console.WriteLine("\nÁlbum: " + nomeAlbum);
                Console.WriteLine("Músicas Cadastradas:");

                for (int i = 0; i < quantidadeMusicas; i++)
                {
                    Console.WriteLine($"{i + 1} {musicas[i]}");
                }


            }
        }
    }