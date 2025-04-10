using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class CadastrarFornecedor
    {
        public static void Fornecedor()
        {
            Console.WriteLine("\n Cadastro de Fornecedores");
            Console.WriteLine(" Digite o codigo do Fornecedor: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine($" Fornecedor {codigo} cadastrado com sucesso");
        }
    }
}
