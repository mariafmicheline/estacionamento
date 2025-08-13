using System;
using SistemaEstacionamento.Entities;

namespace SistemaEstacionamento
{
    class Program
    {
        static void Main()
        {
            decimal precoInicial = 0;
            decimal precoPorHora = 0;

            Console.WriteLine("Bem vindo ao Sistema de Estacionamento!\n"+
                "Digite o preço inicial: ");
            precoInicial = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Agora digite o preço por hora: ");
            precoPorHora= Convert.ToDecimal(Console.ReadLine());

            // Instancia a classe Estacionamento, já com os valores obtidos anteriormente
            Estacionamento es = new Estacionamento(precoInicial,precoPorHora);
            string opcao = string.Empty;
            bool exibirMenu = true;
            // Realiza o loop do menu
            while (exibirMenu) 
            {
                Console.Clear();
                Console.WriteLine("1 - Cadastrar Veiculo");
                Console.WriteLine("2 - Remover Veiculo");
                Console.WriteLine("3 - Listar veiculos");
                Console.WriteLine("4 - Encerrar");
                switch (Console.ReadLine())
                {
                    case "1":
                        es.AdicionarVeiculo();
                            break;

                    case "2":
                        es.RemoverVeiculo();
                        break;

                    case "3":
                        es.ListarVeiculos();
                        break;

                    case "4":
                        exibirMenu = false;
                            break;

                    default:
                        Console.WriteLine("Erro! Digite um valor valido");
                        break;

                        
                }
            }
            Console.WriteLine("O programa encerrou");
        }
    }
}