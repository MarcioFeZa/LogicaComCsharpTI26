using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ler20NumerosMostrarMaior
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num, contador, numMaior;


            numMaior = -1;
            contador = 1;

             while (contador <= 20){
                Console.WriteLine("Digite um numero: ");
                num = int.Parse(Console.ReadLine());
                contador ++;

             if (num > numMaior)
                {
                numMaior = num;
                }
                {

                Console.WriteLine("O numero Maior é : " + numMaior);
                }

            }







        }
    }
}
