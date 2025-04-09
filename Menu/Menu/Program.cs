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
                Console.WriteLine("\n Menu de cadastro\n");
                Console.WriteLine(" 1 - Cadastro de Cliente");
                Console.WriteLine(" 2 - Cadastro de Fornecedor");
                Console.WriteLine(" 3 - Cadastro de Funcionários");
                Console.WriteLine(" 4 - Cadastro de Produtos");
                Console.WriteLine(" 5 - Cadastro de Pedidos");
                Console.WriteLine(" 0 - SAIR");
                Console.WriteLine(" Escolha uma das opções: ");

                while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 0 || opcao > 5)
                //TryParse serve para verificar se o conteudo da variavel é um texto digitado e simbolo ! (exclamação) simcoliza diferente
                //Lemos nessa condição  se (texto) ou (numero menor que 0) ou (numero maior que 5)
                {
                    Console.WriteLine(" Opção Invalida , Digite Novamente");
                }
                switch (opcao)
                {
                    case 1:

                        CadastrarCliente();
                        break;

                    case 2:

                        CadastrarFornecedor();
                        break;

                    case 3:

                        CadastrarFuncionario();
                        break;

                    case 4:


                        CadastrarProdutos();
                        break;

                    case 5:

                        CadastrarPedido();
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
        static void CadastrarCliente()
        {
            Console.WriteLine("\n Cadastro de Clientes");
            Console.WriteLine(" Digite o nome do cliente: ");
            string nome = Console.ReadLine();
            Console.WriteLine($" Cliente {nome} cadastrado com sucesso");
        }
        static void CadastrarFornecedor()
        {
            Console.WriteLine("\n Cadastro de Fornecedores");
            Console.WriteLine(" Digite o codigo do Fornecedor: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine($" Fornecedor {codigo} cadastrado com sucesso");
        }
        static void CadastrarFuncionario()
        { 
            Console.WriteLine("\n Cadastro de Funcionarios");
            Console.WriteLine(" Digite o nome do Funcionario: ");
            string funcionario = Console.ReadLine();
            Console.WriteLine($" Funcionario {funcionario} cadastrado com sucesso");
        }

        static void CadastrarProdutos()
        {
            Console.WriteLine("\n Cadastro de Produtos");
            Console.WriteLine(" Digite o codigo do Produto: ");
            int produto = int.Parse(Console.ReadLine());
            Console.WriteLine($" Fornecedor {produto} cadastrado com sucesso");
        }

        static void CadastrarPedido()
        {
            Console.WriteLine("\n Cadastro de Pedidos");
            Console.WriteLine(" Digite o codigo do Pedido: ");
            int pedido = int.Parse(Console.ReadLine());
            Console.WriteLine($" Fornecedor {pedido} cadastrado com sucesso");
        }

    }
}
