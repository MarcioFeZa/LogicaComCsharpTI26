using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobraEMulta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, excesso, multa = 4, limite = 50;

            Console.WriteLine("RENDIMENTO DIÁRIO");
            Console.WriteLine("\nLimite: 50 Kg");
            Console.WriteLine("\nMulta: R$ 4.00 por kG ultrapassado");
            Console.WriteLine("\nDigitalize o peso do peixe: ");
            peso = double.Parse(Console.ReadLine());

            excesso = (peso - limite);

            Console.WriteLine("\nMulta aplicada: " + excesso * multa + " Reais");
        }
    }
}
