using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


           


namespace ValorAeB
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                /*
            Faça um algoritmo que leia dois valores inteiros A e B, se os valores de A e B forem iguais, deverá somar os dois valores, 
             caso contrário devera multiplicar A por B. Ao final de qualquer um dos cálculos deve-se atribuir o resultado a uma variável C e
             imprimir seu valor na tela.
             */
                int a, b, c;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\r\n          _____                    _____                    _____           _______                   _____          \r\n         /\\    \\                  /\\    \\                  /\\    \\         /::\\    \\                 /\\    \\         \r\n        /::\\____\\                /::\\    \\                /::\\____\\       /::::\\    \\               /::\\    \\        \r\n       /:::/    /               /::::\\    \\              /:::/    /      /::::::\\    \\             /::::\\    \\       \r\n      /:::/    /               /::::::\\    \\            /:::/    /      /::::::::\\    \\           /::::::\\    \\      \r\n     /:::/    /               /:::/\\:::\\    \\          /:::/    /      /:::/~~\\:::\\    \\         /:::/\\:::\\    \\     \r\n    /:::/____/               /:::/__\\:::\\    \\        /:::/    /      /:::/    \\:::\\    \\       /:::/__\\:::\\    \\    \r\n    |::|    |               /::::\\   \\:::\\    \\      /:::/    /      /:::/    / \\:::\\    \\     /::::\\   \\:::\\    \\   \r\n    |::|    |     _____    /::::::\\   \\:::\\    \\    /:::/    /      /:::/____/   \\:::\\____\\   /::::::\\   \\:::\\    \\  \r\n    |::|    |    /\\    \\  /:::/\\:::\\   \\:::\\    \\  /:::/    /      |:::|    |     |:::|    | /:::/\\:::\\   \\:::\\____\\ \r\n    |::|    |   /::\\____\\/:::/  \\:::\\   \\:::\\____\\/:::/____/       |:::|____|     |:::|    |/:::/  \\:::\\   \\:::|    |\r\n    |::|    |  /:::/    /\\::/    \\:::\\  /:::/    /\\:::\\    \\        \\:::\\    \\   /:::/    / \\::/   |::::\\  /:::|____|\r\n    |::|    | /:::/    /  \\/____/ \\:::\\/:::/    /  \\:::\\    \\        \\:::\\    \\ /:::/    /   \\/____|:::::\\/:::/    / \r\n    |::|____|/:::/    /            \\::::::/    /    \\:::\\    \\        \\:::\\    /:::/    /          |:::::::::/    /  \r\n    |:::::::::::/    /              \\::::/    /      \\:::\\    \\        \\:::\\__/:::/    /           |::|\\::::/    /   \r\n    \\::::::::::/____/               /:::/    /        \\:::\\    \\        \\::::::::/    /            |::| \\::/____/    \r\n     ~~~~~~~~~~                    /:::/    /          \\:::\\    \\        \\::::::/    /             |::|  ~|          \r\n                                  /:::/    /            \\:::\\    \\        \\::::/    /              |::|   |          \r\n                                 /:::/    /              \\:::\\____\\        \\::/____/               \\::|   |          \r\n                                 \\::/    /                \\::/    /         ~~                      \\:|   |          \r\n                                  \\/____/                  \\/____/                                   \\|___|          \r\n                                                                                                                     \r\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Faça um programa que leia dois numeros inteiros");
                Console.ResetColor();
                Console.Write("Digite o primeiro numero: ");
                a = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo numero: ");
                b = int.Parse(Console.ReadLine());

                if (a == b)
                {
                    c = a + b;
                    Console.WriteLine("Resultado: " + c);
                }
                else
                {
                    c = a * b;
                    Console.WriteLine("Resultado: " + c);
                }
            }
        }
    }





    

