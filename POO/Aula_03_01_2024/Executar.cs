using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_03_01_2024
{
    public class Executar
    {
        static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();
            List<Produto> produtos = new List<Produto>();
            List<Venda> vendas = new List<Venda>();
            Estoque estoque = new Estoque();

            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Cadastrar Produto");
                Console.WriteLine("3 - Cadastrar Venda");
                Console.WriteLine("4 - Consultar Estoque");
                Console.WriteLine("5 - Gerar Relatório de Funcionários");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Digite a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarCliente(clientes);
                        break;
                    case 2:
                        // CadastrarProduto(produtos, estoque);
                        break;
                    case 3:
                        // CadastrarVenda(vendas, clientes, produtos, estoque);
                        break;
                    case 4:
                        // ConsultarEstoque(estoque);
                        break;
                    case 5:
                        // GerarRelatorioFuncionarios(clientes, produtos, vendas);
                        break;
                    case 0:
                        Console.WriteLine("Saindo do programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                        break;
                }
            } while (opcao != 0);
        }

        static void CadastrarCliente(List<Cliente> clientes)
        {
            // Código para cadastrar clientes
            System.Console.WriteLine("Digite o nome do cliente: ");
            string nome = Console.ReadLine();
            System.Console.WriteLine("Digite o CPF do cliente: ");
            string cpf = Console.ReadLine();
            System.Console.WriteLine("Digite o telefone do cliente: ");
            string telefone = Console.ReadLine();
            System.Console.WriteLine("Digite o endereço do cliente: ");
            string endereco = Console.ReadLine();

            Cliente cliente = new ClienteGold
            {
                Nome = nome,
                CPF = cpf,
                Telefone = telefone,
                Endereco = new Endereco()
                {
                    Rua = endereco.Split(",")[0],
                    Cidade = endereco.Split(",")[1],
                    Estado = endereco.Split(",")[2],
                    CEP = endereco.Split(",")[3]
                }
            };
        }

    }
}
