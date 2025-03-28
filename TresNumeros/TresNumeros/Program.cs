using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TresNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Entre com o primeiro numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre o terceiro numero: ");
            num3 = int.Parse(Console.ReadLine());

            if(num1 > num2 && num1 > num3)
                {
                Console.WriteLine("O numero " + num1 + " é maior !");
                    }
            else if(num2 > num1 && num2 > num3)
                {
                Console.WriteLine("O numero " + num2 + " é maior !");
                    }
            else if(num3> num1 && num3> num2)
                {
                Console.WriteLine("O numero " + num3 + " é maior !");
                    }
            else
                Console.WriteLine("\nOs numeros são iguais !");
        




        }
    }
}
