using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albuns
{
    internal class Program
    {
        static void Main(string[] args)
        {//Crie um sistema de cadastro de Albuns de um artista/banda 
         //em que será possivel cadastrar um numero x de musicas informada pelo usuário.
         //Crie um menu de opções para isso.


            int opcao = 1;

            while (opcao != 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

░█████╗░██████╗░████████╗██╗░██████╗████████╗░█████╗░░██████╗
██╔══██╗██╔══██╗╚══██╔══╝██║██╔════╝╚══██╔══╝██╔══██╗██╔════╝
███████║██████╔╝░░░██║░░░██║╚█████╗░░░░██║░░░███████║╚█████╗░
██╔══██║██╔══██╗░░░██║░░░██║░╚═══██╗░░░██║░░░██╔══██║░╚═══██╗
██║░░██║██║░░██║░░░██║░░░██║██████╔╝░░░██║░░░██║░░██║██████╔╝
╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═════╝░");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("\n Menu de cadastro\n");
                Console.WriteLine(" 1 - Cadastro de Artista");
                Console.WriteLine(" 0 - SAIR");
                Console.WriteLine(" Escolha uma das opções: ");

                Console.ResetColor();

                while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 0 || opcao > 1)

                //Crie um sistema de cadastro de Albuns de um artista/banda 
                //em que será possivel cadastrar um numero x de musicas informada pelo usuário.
                //Crie um menu de opções para isso.
                {
                    Console.WriteLine(" Opção Invalida , Digite Novamente");
                }
                switch (opcao)
                {
                    case 1:

                        CadastrarArtistaAlbuns.ArtistaAlbuns();
                        break;

                    case 0:

                        Console.WriteLine(" Saindo...");
                        break;

                    default:

                        Console.WriteLine(" Opção Invalida...Tente novamente");
                        break;

                }

                if (opcao != 0)
                {
                    Console.WriteLine("\n Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            } 
        }
        
        

    }
}
