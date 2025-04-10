using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albuns
{
    internal class CadastrarArtistaAlbuns
    {
       public static void ArtistaAlbuns()
        {
            Console.WriteLine("\n Cadastro de Artistas / Album");
            Console.WriteLine(" Digite o nome do artista: ");
            string artista = Console.ReadLine();
            Console.WriteLine("Digite o nome do album");
            string album = Console.ReadLine();
            Console.WriteLine("Digite o numero de músicas no album: ");
            int musica = int.Parse(Console.ReadLine());
            int contador = 1;
            while (contador <= musica)
            {
                Console.WriteLine($"Digite o nome da {contador}° música: ");
                string nomeMusica = Console.ReadLine();
                contador++;
            }
            Console.WriteLine($" Artista {artista} cadastrado com sucesso");
        }
    }
}
