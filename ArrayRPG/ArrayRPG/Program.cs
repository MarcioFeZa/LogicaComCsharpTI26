using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JogoRPG
{
    internal class Program
    {
        public class Ficha
        {
            //propriedades
            public string nomeDoJogador;
            public string nomeDoPersonagem;
            public string raca;
            public string classe;
            public int vida;

            //método
            public void ImprimirFicha()
            {
                Console.WriteLine(" \n");
                Console.WriteLine("===============================");
                Console.WriteLine("===== FICHA DO PERSONAGEM =====");
                Console.WriteLine("Nome do personagem: " + nomeDoPersonagem);
                Console.WriteLine("Raça: " + raca);
                Console.WriteLine("Classe: " + classe);
                Console.WriteLine("Vida: " + vida);
                Console.WriteLine("===============================");
                Console.WriteLine("===============================");
                Console.WriteLine("\n");
            }
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            int d6Jogador = 0;
            int d6Inimigo = 0;

            Ficha personagemPrincipal = new Ficha(); // instanciar novo objeto
            personagemPrincipal.nomeDoJogador = "Guto";
            personagemPrincipal.nomeDoPersonagem = "Aldir";
            personagemPrincipal.raca = "Elfo";
            personagemPrincipal.classe = "Guerreiro";
            personagemPrincipal.vida = 100;

            Console.WriteLine("======= AVENTURA COMEÇA =======");
            personagemPrincipal.ImprimirFicha();

            Console.WriteLine("Você está bebendo em uma taverna.");
            Console.WriteLine("Uma pessoa esbarra em você. O que você faz?\n[ 1 ] se vira\n[ 2 ] continua como se nada fosse ");

            string decisao = Console.ReadLine();

            if (decisao == "1")
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("Agora começa!!!");
                Ficha inimigo = new Ficha();
                inimigo.nomeDoJogador = "NPC";
                inimigo.nomeDoPersonagem = "Baltazar";
                inimigo.raca = "ORC";
                inimigo.classe = "Ladrão";
                inimigo.vida = 50;
                inimigo.ImprimirFicha();

                while (inimigo.vida > 0 && personagemPrincipal.vida > 0)
                {

                    //rolar os dados
                    d6Jogador = random.Next(1, 6);
                    d6Inimigo = random.Next(1, 6);

                    //comparar os valores dos dados
                    if (d6Jogador > d6Inimigo)
                    {
                        //se o jogador ganhou, dar o dano no inimigo
                        inimigo.vida -= 10;
                        Console.WriteLine("Boa, consegui acertar");
                    }
                    else if (d6Jogador < d6Inimigo)
                    {
                        //se o inimigo ganhou, dar o dano no jogador
                        personagemPrincipal.vida -= 10;
                        Console.WriteLine("Eita, essa doeu!");
                    }
                    else
                    {
                        Console.WriteLine("Nada acontece!");
                    }

                    //exibir a vida do jogador e do inimigo
                    Console.WriteLine("Vida do jogador: " + personagemPrincipal.vida);
                    Console.WriteLine("Vida do inimigo: " + inimigo.vida);
                    Console.WriteLine("\n");
                    Thread.Sleep(2000);
                }

                //se a vida do jogador chegar a 0 mostrar "você perdeu"
                if (personagemPrincipal.vida == 0)
                {
                    Console.WriteLine("Você perdeu");
                }
                else
                {
                    //se a vida do inimigo chegar a 0 mostrar "você ganhou"
                    Console.WriteLine("Você ganhou");
                }
            }
            else
            {
                Console.WriteLine("Você continua a beber");
            }
        }
    }
}
