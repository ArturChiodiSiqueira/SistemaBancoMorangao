using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.ConstrainedExecution;

namespace SistemaBancoMorangao
{
    internal class Program
    {
        static List<Cliente> lstClientes;
        static List<Funcionario> lstFuncionarios;

        static List<int> lstNumeroContas;
        static List<int> lstIdFuncionarios;

        static void Main(string[] args)
        {
            Console.Title = "SISTEMA BANCO MORANGÃO";
            lstClientes = new List<Cliente>();
            lstFuncionarios = new List<Funcionario>();

            lstNumeroContas = new List<int>();
            lstIdFuncionarios = new List<int>();

            MostrarMenuInicial();
        }

        static int RetornaIdFuncionario()
        {
            int id = 0;

            foreach (int idExistente in lstIdFuncionarios)
            {
                if (idExistente > id)
                {
                    id = idExistente;
                }
            }
            return id + 1;
        }

        static int RetornaNumeroConta()
        {
            int numeroConta = 0;

            foreach (int numeroExistente in lstNumeroContas)
            {
                if (numeroExistente > numeroConta)
                {
                    numeroConta = numeroExistente;
                }
            }
            return numeroConta + 1;
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
            //string senha = "123";

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
                            foreach (Cliente cliente in lstClientes)
                            {
                                if (cliente != null)
                                {
                                    Console.WriteLine(cliente + "\n");
                                }
                                else
                                {
                                    Console.WriteLine("NÃO HÁ CLIENTES CADASTRADOS AINDA.");
                                }
                            }
                            Console.WriteLine("\nAperte qualquer tecla para voltar!");
                            Console.ReadKey();
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
            //string senha = "456";

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
                            foreach (Funcionario funcionario in lstFuncionarios)
                            {
                                if (funcionario != null)
                                {
                                    Console.WriteLine(funcionario + "\n");
                                }
                                else
                                {
                                    Console.WriteLine("NÃO HÁ NOVOS FUNCIONARIOS CADASTRADOS AINDA.");
                                }
                            }
                            Console.WriteLine("\nAperte qualquer tecla para voltar!");
                            Console.ReadKey();
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
            //string senha = senha cadastrada pelo cliente na hora de criar a conta

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
            Console.WriteLine("VOCÊ ESTÁ PRESTES A ABRIR A CONTA!\nMAS ANTES NOS INFORME ALGUNS DADOS DO CLIENTE...\n\n");
            Console.WriteLine("\nAperte qualquer tecla para executar a solicitação!");
            Console.ReadKey();

            Console.Write("Informe o nome completo: ");
            string nome = Console.ReadLine();

            Console.Write("Informe o telefone/celular: ");
            string telefone = Console.ReadLine();

            Console.Write("Informe o Email: ");
            string email = Console.ReadLine();

            Console.Write("Informe o CPF: ");
            string cpf = Console.ReadLine();

            Console.Write("Informe o genero (M ou F): ");
            char genero = char.Parse(Console.ReadLine().ToUpper());

            Pessoa pessoa = new Pessoa(nome, telefone, email, cpf, genero);

            Console.Write("Informe o logradouro: ");
            string logradouro = Console.ReadLine();

            Console.Write("Informe o numero residencial: ");
            string numero = Console.ReadLine();

            Console.Write("Informe o bairro: ");
            string bairro = Console.ReadLine();

            Console.Write("Informe a cidade: ");
            string cidade = Console.ReadLine();

            Console.Write("Informe o CEP: ");
            string cep = Console.ReadLine();

            Console.Write("Informe o complemento: ");
            string complemento = Console.ReadLine();

            pessoa.Endereco = new Endereco(logradouro, numero, bairro, cidade, cep, complemento);

            Console.WriteLine("estudante? (s/n)");
            string estudante = Console.ReadLine().ToLower();
            Console.WriteLine("qual a renda?");
            double renda = double.Parse(Console.ReadLine());

            Cliente cliente = new Cliente(estudante == "s" ? true : false, renda, RetornaNumeroConta(), pessoa);

            lstClientes.Add(cliente);

            Console.Clear();
            Console.WriteLine("Dados cadastrados:\n" + cliente);
            Console.WriteLine("\n\nSolicitação concluída!");
            Console.WriteLine("Aperte qualquer tecla para voltar!");
            Console.ReadKey();
            MostrarMenuInicial();
        }

        static void CadastrarFuncionario()
        {
            Console.WriteLine("VOCÊ IRÁ CADASTRAR UM NOVO FUNCIONÁRIO!\nINFORME OS DADOS DO FUNCIONARIO...\n\n");
            Console.WriteLine("\nAperte qualquer tecla para cadastrar!");
            Console.ReadKey();

            Console.Write("Informe o nome completo: ");
            string nome = Console.ReadLine();

            Console.Write("Informe o telefone/celular: ");
            string telefone = Console.ReadLine();

            Console.Write("Informe o Email: ");
            string email = Console.ReadLine();

            Console.Write("Informe o CPF: ");
            string cpf = Console.ReadLine();

            Console.Write("Informe o genero (M ou F): ");
            char genero = char.Parse(Console.ReadLine().ToUpper());

            Pessoa pessoa = new Pessoa(nome, telefone, email, cpf, genero);

            Console.Write("Informe o logradouro: ");
            string logradouro = Console.ReadLine();

            Console.Write("Informe o numero residencial: ");
            string numero = Console.ReadLine();

            Console.Write("Informe o bairro: ");
            string bairro = Console.ReadLine();

            Console.Write("Informe a cidade: ");
            string cidade = Console.ReadLine();

            Console.Write("Informe o CEP: ");
            string cep = Console.ReadLine();

            Console.Write("Informe o complemento: ");
            string complemento = Console.ReadLine();

            pessoa.Endereco = new Endereco(logradouro, numero, bairro, cidade, cep, complemento);

            string cargo;

            Console.Write("Informe o nivel de acesso do funcionário (1 - funcionario | 2 - gerente): ");
            int niveldeAcesso = int.Parse(Console.ReadLine());

            if (niveldeAcesso == 1)
                cargo = "FUNCIONARIO";
            else
                cargo = "GERENTE";

            Funcionario funcionario = new Funcionario(pessoa, RetornaIdFuncionario(), cargo, niveldeAcesso == 1 ? 1 : 2);

            lstFuncionarios.Add(funcionario);

            Console.Clear();
            Console.WriteLine("Dados cadastrados:\n" + funcionario);
            Console.WriteLine("\n\nCadastro concluído!");
            Console.WriteLine("Aperte qualquer tecla para voltar!");
            Console.ReadKey();
            MostrarMenuInicial();
        }

        //static void ColetaDados()
        //{

        //}
    }
}