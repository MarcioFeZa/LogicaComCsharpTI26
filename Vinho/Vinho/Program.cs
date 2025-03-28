using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tinto = 0, branco = 0;
            string tipo_vinho;


            while(true)
            {
                Console.WriteLine("Digite o tipo de vinho (t para tinto, b para branco, f para finalizar): ");
                tipo_vinho = Console.ReadLine();


            if(tipo_vinho == "f")
                {
                    break;
                  }
                else
                {
                    if(tipo_vinho == "t")
                    {
                        tinto++;
                     }
                    else
                    {
                        if(tipo_vinho == "b")
                        {
                            branco++;
                        }
                        else
                        {
                            Console.WriteLine("Tipo ínvalido! Digite novamente. \n");
          }
                    }
                }
            }
            Console.WriteLine("Quantidade de vinhos tintos: " + tinto + "\n");
            Console.WriteLine("Quantidade de vinhos brancos: " + branco + "\n");


        }
    }
}
