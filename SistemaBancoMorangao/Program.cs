using System;

namespace SistemaBancoMorangao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "SISTEMA BANCO MORANGÃO";

            MostrarMenuInicial();
        }

        static void MostrarMenuInicial()
        {
            string opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("\n\tQUAL SEU TIPO DE ACESSO COM BASE NAS OPÇÕES?\n");
                Console.WriteLine("\t|°°°°°°°°°°°°°  MENU  INICIAL  °°°°°°°°°°°°°|");
                Console.WriteLine("\t|   opção 0 : funcionario                   |");
                Console.WriteLine("\t|                                           |");
                Console.WriteLine("\t|   opção 1 : cliente                       |");
                Console.WriteLine("\t|___________________________________________|");

                Console.Write("\n\tInforme a opcao: ");
                opcao = Console.ReadLine();

                if (opcao != "0" && opcao != "1")
                {
                    Console.WriteLine("'" + opcao + "' é uma opcao INVALIDA! Para voltar ao MENU, pressione QUALQUER TECLA!");
                    Console.ReadKey();
                    Console.Clear();
                }

                else
                {
                    switch (opcao)
                    {
                        case "0":
                            Console.Clear();
                            MostrarMenuFuncionario();
                            break;

                        case "1":
                            Console.Clear();
                            MostrarMenuCliente();
                            break;
                    }
                }
            } while (opcao != "0" && opcao != "1");
        }

        static void MostrarMenuFuncionario()
        {
            string opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("\n\tPROSSIGA COM UMA DAS OPÇÕES DO MENU.\n");
                Console.WriteLine("\t|°°°°°°°°°°°  MENU  FUNCIONARIO  °°°°°°°°°°°|");
                Console.WriteLine("\t|   opção 0 : solicitar abertura de conta   |");
                Console.WriteLine("\t|                                           |");
                Console.WriteLine("\t|   opção 1 : ver clientes                  |");
                Console.WriteLine("\t|                                           |");
                Console.WriteLine("\t|   opção 2 : nivel de acesso gerente       |");
                Console.WriteLine("\t|___________________________________________|");

                Console.Write("\n\tInforme a opcao: ");
                opcao = Console.ReadLine();

                if (opcao != "0" && opcao != "1" && opcao != "2")
                {
                    Console.WriteLine("'" + opcao + "' é uma opcao INVALIDA! Para voltar ao MENU, pressione QUALQUER TECLA!");
                    Console.ReadKey();
                    Console.Clear();
                }

                else
                {
                    switch (opcao)
                    {
                        case "0":
                            Console.Clear();
                            CadastrarCliente();
                            break;
                        case "1":
                            Console.Clear();
                            //ListarClientes();
                            break;

                        case "2":
                            Console.Clear();
                            AtividadesGerente();
                            break;
                    }
                }
            } while (opcao != "0");
        }

        static void AtividadesGerente()
        {
            string opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("\n\tPROSSIGA COM UMA DAS OPÇÕES DO MENU.\n");
                Console.WriteLine("\t|°°°°°°°°°°°  MENU PARA GERENTE  °°°°°°°°°°°|");
                Console.WriteLine("\t|   opção 0 : cadastrar funcionário         |");
                Console.WriteLine("\t|                                           |");
                Console.WriteLine("\t|   opção 1 : ver funcionários              |");
                Console.WriteLine("\t|                                           |");
                Console.WriteLine("\t|   opção 2 : gerenciar aprovações          |");
                Console.WriteLine("\t|___________________________________________|");

                Console.Write("\n\tInforme a opcao: ");
                opcao = Console.ReadLine();

                if (opcao != "0" && opcao != "1" && opcao != "2")
                {
                    Console.WriteLine("'" + opcao + "' é uma opcao INVALIDA! Para voltar ao MENU, pressione QUALQUER TECLA!");
                    Console.ReadKey();
                    Console.Clear();
                }

                else
                {
                    switch (opcao)
                    {
                        case "0":
                            Console.Clear();
                            CadastrarFuncionario();
                            break;
                        case "1":
                            Console.Clear();
                            //ListarFuncionarios();
                            break;

                        case "2":
                            Console.Clear();
                            VerAprovacoes();
                            break;
                    }
                }
            } while (opcao != "0");
        }

        static void VerAprovacoes()
        {

        }

        static void MostrarMenuCliente()
        {
            string opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("\n\tPROSSIGA COM UMA DAS OPÇÕES DO MENU.\n");
                Console.WriteLine("\t|°°°°°°°°°°°°°  MENU  CLIENTE  °°°°°°°°°°°°°|");
                Console.WriteLine("\t|   opção 0 : sair                          |");
                Console.WriteLine("\t|                                           |");
                Console.WriteLine("\t|   opção 1 : entrar                        |");
                Console.WriteLine("\t|___________________________________________|");

                Console.Write("\n\tInforme a opcao: ");
                opcao = Console.ReadLine();

                if (opcao != "0" && opcao != "1")
                {
                    Console.WriteLine("'" + opcao + "' é uma opcao INVALIDA! Para voltar ao MENU, pressione QUALQUER TECLA!");
                    Console.ReadKey();
                    Console.Clear();
                }

                else
                {
                    switch (opcao)
                    {
                        case "0":
                            Console.WriteLine("\nVOCÊ ESCOLHEU SAIR.");
                            break;
                        case "1":
                            Console.Clear();
                            AtividadesCliente();
                            break;
                    }
                }
            } while (opcao != "0");
        }

        static void AtividadesCliente()
        {

        }

        static void CadastrarCliente()
        {
            //PedeDadosCadastrais();
            Console.WriteLine("VOCÊ ESTÁ PRESTES A ABRIR A CONTA!\nMAS ANTES NOS INFORME ALGUNS DADOS...\n\n");
            Cliente cliente = new Cliente();
            Console.WriteLine("\nAperte qualquer tecla para executar a solicitação!");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Dados cadastrados:\n" + cliente);
            Console.WriteLine("\n\nSolicitação concluída!");
            Console.ReadKey();
        }

        static void CadastrarFuncionario()
        {
            Console.WriteLine("VOCÊ IRÁ CADASTRAR UM NOVO FUNCIONÁRIO!\nINFORME OS DADOS...\n\n");
            Funcionario funcionario = new Funcionario();
            Console.WriteLine("\nAperte qualquer tecla para cadastrar!");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Dados cadastrados:\n" + funcionario);
            Console.WriteLine("\n\nCadastro concluído!");
            Console.ReadKey();
        }

        //static void PedeDadosCadastrais()
        //{
        //    Pessoa pessoa = new Pessoa();
        //    Console.WriteLine("\n" + pessoa);
        //    Console.ReadKey(); 
        //}


    }
}
