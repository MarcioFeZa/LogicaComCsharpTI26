using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositivoNegativoZero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite um numero qualquer: ");
            numero = int.Parse(Console.ReadLine());

            if(numero < 0)
            {
                Console.WriteLine("Numero negativo");
            }

            else if(numero> 0)
            {
                Console.WriteLine("Numero positivo");
            }

            else
            { 
                Console.WriteLine("Igual a Zero");
            }




        }
    }
}
