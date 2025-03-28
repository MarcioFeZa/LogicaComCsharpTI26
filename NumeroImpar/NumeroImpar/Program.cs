using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 99;
            while (contador > 0)
            {
                Console.WriteLine(contador + "\n");
                contador = contador - 2;

            }
        }
    }
}
