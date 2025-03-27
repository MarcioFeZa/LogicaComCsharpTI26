using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroParEnquanto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int contadorPares = 0;


            while(contadorPares <= 100)//while mesma função que enquanto no portugol
            {
                if(contadorPares % 2 == 0)
            {
                    Console.WriteLine(contadorPares + "\n");
            }
                contadorPares++;
            }












        }
    }
}
