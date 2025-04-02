using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {//Faça um algoritmo que calcule o IMC (Índice de Massa Corporal) de uma pessoa, leia o seu peso e sua altura e imprima na tela sua condição 
         //de acordo com a tabela abaixo:Fórmula do IMC = peso / (altura) ²Tabela Condições IMC ,Abaixo de 18,5 | Abaixo do peso
         //  Entre 18,6 e 24,9 | Peso ideal(parabéns)
         //  Entre 25,0 e 29,9 | Levemente acima do peso
         //  Entre 30,0 e 34,9 | Obesidade grau I
         //  Entre 35,0 e 39,9 | Obesidade grau II(severa)
         //  Maior ou igual a 40 | Obesidade grau III(mórbida)

            double peso, altura, imc;

            Console.WriteLine("Calculo de IMC ");

            Console.WriteLine("Digite o seu peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.Write("Digite a sua altura com virgula: ");
            altura = double.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            Console.Write(" O seu IMC é: " + imc);

            if (imc <= 18.5)
            {
                Console.WriteLine(" Abaixo do peso, O seu IMC é: " + imc);
            }
            else if (imc >= 18.6 && imc <= 24.9)
            {
                Console.WriteLine(" Peso ideal(parabéns), O seu IMC é: " + imc);
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine(" Levemente acima do peso, O seu IMC é: " + imc);
            }
            else if (imc > 30 && imc < 34.9)
            {
                Console.WriteLine(" Obesidade grau I, O seu IMC é: " + imc);
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                Console.WriteLine(" Obesidade grau II(severa), O seu IMC é: " + imc);
            }
            else
            {
                Console.WriteLine(" Obesidade grau III(mórbida), O seu IMC é: " + imc);
            }

        }
    }
}
