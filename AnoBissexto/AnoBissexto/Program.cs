using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnoBissexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ano;

            Console.WriteLine("digite o ano: ");
            ano = double.Parse(Console.ReadLine());

            if(ano % 4 == 0 || ano % 100 == 0 && ano % 400 == 0)
            {
                Console.WriteLine("é bissexto");
            }
            else
            {
                Console.WriteLine("nao é bissexto");
            }



        }
    }
}
