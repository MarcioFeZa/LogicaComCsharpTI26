using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KenoPerna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double perna_direita, perna_esquerda;

            Console.WriteLine("Digite a medida da perna direita: ");
            perna_direita = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a medida da perna esquerda: ");
            perna_esquerda = double.Parse(Console.ReadLine());

            if(perna_direita > perna_esquerda)
            {
                Console.WriteLine("Cotó na perna esquerda ");
            }
            else if(perna_esquerda> perna_direita)
            {
                Console.WriteLine("Cotó na perna direita ");
            }
            else

                Console.WriteLine("Pernas normais ");




        }
    }
}
