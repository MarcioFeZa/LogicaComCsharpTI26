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

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
░█████╗░██╗░░░░░██████╗░██╗░░░██╗███╗░░██╗░██████╗
██╔══██╗██║░░░░░██╔══██╗██║░░░██║████╗░██║██╔════╝
███████║██║░░░░░██████╦╝██║░░░██║██╔██╗██║╚█████╗░
██╔══██║██║░░░░░██╔══██╗██║░░░██║██║╚████║░╚═══██╗
██║░░██║███████╗██████╦╝╚██████╔╝██║░╚███║██████╔╝
╚═╝░░╚═╝╚══════╝╚═════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
            Console.ResetColor();

            Console.WriteLine("\n Cadastro de Albuns/Bandas/Músicas \n");
            Console.WriteLine("\n Cadastro de Músicas");
            Console.WriteLine(" Digite o nome da Música: ");
            string musica = Console.ReadLine();
            Console.WriteLine($" A música {musica} foi cadastrada com sucesso");







        }
    }
}
