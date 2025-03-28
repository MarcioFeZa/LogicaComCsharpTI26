using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    internal class Program
    {
        static void Main(string[] args)
        {// Uma fabrica tem uma linha de produção capaz de produzir 400 peças/dia
         //Um funcionário controla a qualidade,cadastrando o número de peça e o seus estado
         //(aprovado ou reprovado).Criar um programa para cadastrar o contole de qualidade e 
         //imprimir o total de peças aprovadas e reprovadas no final do dia
           
            int contador, reprovado, aprovado, estado;
            aprovado = 0;
            reprovado = 0;


            for(contador = 1; contador <= 10; contador++) 
            {
                Console.WriteLine("PEÇA ", contador, "\n");
            Console.WriteLine("Digite 1 para APROVADA ou 2 para REPROVADA: ");
            estado = int.Parse(Console.ReadLine());

            if(estado == 1) 
                {
                    aprovado = aprovado + 1;
                 }
                else if(estado == 2) 
                {
                    reprovado = reprovado + 1;
                 }
                else 
                {
                    Console.WriteLine("Estado inválido! Digite 1 ou 2.\n");
                    contador = contador - 1;
                }
             }
            Console.WriteLine("Quantidade de peças aprovadas: " + aprovado + "\n");
            Console.WriteLine("Quantidade de peças reprovadas: " + reprovado + "\n");

        }
    }
}
