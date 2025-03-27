using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroEntre20e90
{
    internal class Program
    {
        static void Main(string[] args)
        {//Construa um algoritmo que indique se um número digitado está compreendido entre 20 e 90 
         //ou não (20 e 90 não estão na faixa de valores).

            int numero;

            Console.Write("Digite um numero inteiro: ");
            numero = int.Parse(Console.ReadLine());


            if (numero > 19 && numero < 91)  //if é igual ao (se) no portugol e o && é igual ao (e)
            {
                Console.WriteLine("Estão na faixa de valores entre 20 e 90");
            }
            else
            {//else é igual ao (senao) no portugol

                Console.WriteLine("Não estão na faixa de valores entro 20 e 90");



            }

                } } }