using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class CadastrarPedido
    {
        public static void Pedido()
        {
            Console.WriteLine("\n Cadastro de Pedidos");
            Console.WriteLine(" Digite o codigo do Pedido: ");
            int pedido = int.Parse(Console.ReadLine());
            Console.WriteLine($" Pedido {pedido} cadastrado com sucesso");
        }
    }
}
