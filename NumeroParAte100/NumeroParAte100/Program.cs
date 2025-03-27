using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroParAte100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mostre somente os números pares de 1 a 100

            int contador;


            for(contador = 2; contador <= 100; contador++) //for é a mesma coisa que (para) no portugol
            {
            if(contador % 2 == 0)
            {
                    Console.WriteLine(contador + "\n");
            }

            }
            
















        }
    }
}
