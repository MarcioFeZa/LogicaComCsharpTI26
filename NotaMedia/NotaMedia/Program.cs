using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, media;


            Console.WriteLine("Digite a nota primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());


            Console.WriteLine("Digite a nota terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());


            Console.WriteLine("Digite a nota quarta nota: ");
            nota4 = double.Parse(Console.ReadLine());


            media = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine(" Media: " + media);




        }
    }
}
