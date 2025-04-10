using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class CadastrarProduto
    {
        public static void Produto()
        {
            Console.WriteLine("\n Cadastro de Produtos");
            Console.WriteLine(" Digite o codigo do Produto: ");
            int produto = int.Parse(Console.ReadLine());
            Console.WriteLine($" Produto {produto} cadastrado com sucesso");
        }
    }
}
