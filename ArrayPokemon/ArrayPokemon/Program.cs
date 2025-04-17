using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] pokemon = { "Bulbassaur", "Charmander", "Squirtle","Caterpie", "Weedle", "Pidgey", "Rattata", "Ekans", "Pikachu", "Nidoran"};
            string[] tipo = { "Planta", "Fogo ", "Água ", "Bug ", "Bug ", "Normal", "Normal", "Poison", "Eletric", "Poison"};
            double[] tamanho = { 0.7, 0.6, 0.5, 0.3, 0.3, 0.3, 0.3, 2.0, 0.4, 0.4};
            double[] peso = { 6.9, 8.5, 9.0, 2.9, 3.2, 1.8, 3.5, 6.9, 6.0, 7.0};

          

            Console.WriteLine(" Nome do Pokemon: " + pokemon[0]);
            Console.WriteLine(" Tipo: " + tipo[0]);
            Console.WriteLine(" Tamanho: " + tamanho[0]);
            Console.WriteLine(" Peso: " + peso[0]);

            Console.WriteLine(" Total de Pokemons: " + pokemon.Length);
           

            Console.WriteLine(" LISTAGEM DE POKEMONS");
            Console.WriteLine("ID\tNOME\t\tTIPO\t\t\tTAMANHO\t\t\t\tPESO");
            for (int i =  0; i < pokemon.Length; i++)
            {
                Console.Write(i);
                Console.Write("\t");
                Console.Write(pokemon[i]);
                Console.Write("\t\t");
                Console.Write(tipo[i]);
                Console.Write("\t\t\t");
                Console.Write(tamanho[i]);
                Console.Write("\t\t\t\t");
                Console.WriteLine(peso[i]);
            }




        }
    }
}