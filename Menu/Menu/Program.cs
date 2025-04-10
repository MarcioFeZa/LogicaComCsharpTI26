using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um sistema de menu em cada opção cadastre um item, controlando o acesso do teclado.

            int opcao = 1;
            while (opcao != 0)
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"
███╗░░░███╗███████╗███╗░░██╗██╗░░░██╗
████╗░████║██╔════╝████╗░██║██║░░░██║
██╔████╔██║█████╗░░██╔██╗██║██║░░░██║
██║╚██╔╝██║██╔══╝░░██║╚████║██║░░░██║
██║░╚═╝░██║███████╗██║░╚███║╚██████╔╝
╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░╚═════╝░");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n Menu de cadastro\n");
                Console.WriteLine(" 1 - Cadastro de Cliente");
                Console.WriteLine(" 2 - Cadastro de Fornecedor");
                Console.WriteLine(" 3 - Cadastro de Funcionários");
                Console.WriteLine(" 4 - Cadastro de Produtos");
                Console.WriteLine(" 5 - Cadastro de Pedidos");
                Console.WriteLine(" 0 - SAIR");
                Console.WriteLine(" Escolha uma das opções: ");
                Console.ResetColor();

                while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 0 || opcao > 5)
                //TryParse serve para verificar se o conteudo da variavel é um texto digitado e simbolo ! (exclamação) simcoliza diferente
                //Lemos nessa condição  se (texto) ou (numero menor que 0) ou (numero maior que 5)
                {
                    Console.WriteLine(" Opção Invalida , Digite Novamente");
                }
                switch (opcao)
                {
                    case 1:

                        CadastrarCliente.Cliente();
                        break;

                    case 2:

                        CadastrarFornecedor.Fornecedor();
                        break;

                    case 3:

                        CadastrarFuncionario.Funcionario();
                        break;

                    case 4:


                        CadastrarProduto.Produto();
                        break;

                    case 5:

                        CadastrarPedido.Pedido();
                        break;

                    case 0:

                        Console.WriteLine(" Saindo...");
                        break;

                    default:

                        Console.WriteLine(" 0Opção Invalida...Tente novamente");
                        break;

                }

                if (opcao != 0)
                {
                    Console.WriteLine("\n Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }  

    }
}
