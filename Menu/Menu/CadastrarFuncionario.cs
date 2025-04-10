using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class CadastrarFuncionario
    {
       public static void Funcionario()
        {
            Console.WriteLine("\n Cadastro de Funcionarios");
            Console.WriteLine(" Digite o codigo do Funcionario: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine($" Funcionario {codigo} cadastrado com sucesso");
        }
    }
}
