using System;
using System.Collections.Generic;

namespace SistemaBancoMorangao
{
    internal class Program
    {
        static List<Cliente> lstClientesPendentes;
        static List<Cliente> lstClientesAprovados;
        static List<Funcionario> lstFuncionarios;

        static List<int> lstNumeroContas;
        static List<int> lstIdFuncionarios;

        static void Main(string[] args)
        {
            Console.Title = "SISTEMA BANCO MORANGÃO";
            lstClientesPendentes = new List<Cliente>();
            lstClientesAprovados = new List<Cliente>();
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
            int idRetorno = id + 1;
            lstIdFuncionarios.Add(idRetorno);
            return idRetorno;
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
            int numeroRetorno = numeroConta + 1;
            lstNumeroContas.Add(numeroRetorno);

            return numeroRetorno;
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
                Console.WriteLine("\t|                                           |");
                Console.WriteLine("\t|   opção 3 : MENU INICIAL                  |");
                Console.WriteLine("\t|___________________________________________|");

                Console.Write("\n\tInforme a opcao: ");
                opcao = Console.ReadLine();

                if (opcao != "0" && opcao != "1" && opcao != "2" && opcao != "3")
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
                            foreach (Cliente cliente in lstClientesAprovados)
                            {
                                if (cliente != null)
                                {
                                    Console.WriteLine(cliente + "\n");
                                }
                                else
                                {
                                    Console.WriteLine("NÃO HÁ NOVOS CLIENTES CADASTRADOS AINDA.");
                                }
                            }
                            Console.WriteLine("\nAperte qualquer tecla para voltar!");
                            Console.ReadKey();
                            break;

                        case "2":
                            Console.Clear();
                            AtividadesGerente();
                            break;

                        case "3":
                            Console.Clear();
                            MostrarMenuInicial();
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
                Console.WriteLine("\t|                                           |");
                Console.WriteLine("\t|   opção 3 : MENU INICIAL                  |");
                Console.WriteLine("\t|___________________________________________|");

                Console.Write("\n\tInforme a opcao: ");
                opcao = Console.ReadLine();

                if (opcao != "0" && opcao != "1" && opcao != "2" && opcao != "3")
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

                        case "3":
                            Console.Clear();
                            MostrarMenuInicial();
                            break;
                    }
                }
            } while (opcao != "0");
        }

        // fazer uma outra lista para guardar as contas aprovadas, essa ss sera a lista de clientes
        static void VerAprovacoes()
        {
            string opcao;
            do
            {
                Console.WriteLine("         TIPOS DE APROVAÇÕES");
                Console.WriteLine("(1 - Abertura de Conta | 2 - Emprétimo)");
                Console.Write("\nEscolha o Tipo deAprovação ou tecle (3) para voltar ao MENU INICIAL: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        AprovarAberturaDeConta();
                        break;

                    case "2":
                        AprovarEmprestimo();
                        break;

                    case "3":
                        MostrarMenuInicial();
                        break;
                }
            } while (opcao != "1" && opcao != "2");
        }

        static void AprovarAberturaDeConta()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("LISTA DE CONTAS A SEREM APROVADAS!");
            Console.WriteLine("----------------------------------");

            for (int i = 0; i < lstClientesPendentes.Count; i++)
            {
                Cliente cliente = lstClientesPendentes[i];

                Console.WriteLine("\n" + cliente + "\n");

                string opcao;
                Console.WriteLine("deseja aprovar este cliente (1 - sim | 2 - não)");
                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    cliente.AtualizaStatus();
                    Console.WriteLine("APROVADO.");

                    lstClientesAprovados.Add(cliente);

                    lstClientesPendentes.Remove(cliente);

                    i -= 1;
                }

                else
                {
                    Console.WriteLine("NÃO APROVADO.");

                    lstClientesPendentes.Remove(cliente);
                }
            }

            Console.WriteLine("Nao ha mais clientes. aperte qualquer coisa para voltar");
            Console.ReadKey();
            MostrarMenuInicial();

            //Console.Write("\n\nInforme o numero da conta do cliente que deseja aprovar: ");
            //int numeroInformado = int.Parse(Console.ReadLine());

            //string opcao;
            //Console.WriteLine("deseja aprovar este cliente (1 - sim | 2 - não)");
            //Console.Write("Escolha a opcao: ");
            //opcao = Console.ReadLine();

            //if (opcao == "1")
            //{
            //    cliente.
            //}

            //Cliente clientependente = new Cliente();


            //switch (opcao)
            //{
            //    case "1":
            //        if (nomeInformado == clientependente.Pessoa.Nome)
            //        {
            //            lstClientesAprovados.Add(clientependente);
            //            lstClientesPendentes.Remove(clientependente);
            //        }
            //        else
            //        {
            //            Console.WriteLine("cliente inesistente.");
            //        }
            //        break;

            //    case "2":
            //        if (nomeInformado == clientependente.Pessoa.Nome)
            //        {
            //            lstClientesPendentes.Remove(clientependente);
            //        }
            //        else
            //        {
            //            Console.WriteLine("cliente inesistente.");
            //        }
            //        break;
            //}


            Console.WriteLine("\nAperte qualquer tecla para voltar!");

            Console.ReadKey();
        }

        static void AprovarEmprestimo()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("LISTA DE EMPRESTIMOS A SEREM APROVADOS!");
            Console.WriteLine("---------------------------------------");

            Console.ReadKey();
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
                Console.WriteLine("\t|                                           |");
                Console.WriteLine("\t|   opção 2 : MENU INICIAL                  |");
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
                            Console.WriteLine("\nVOCÊ ESCOLHEU SAIR.");
                            break;
                        case "1":
                            Console.Clear();
                            Console.WriteLine("Para prosseguir nos informe o numero da conta e a senha.");
                            //se a conta existir e a senha estiver correta chama as atividades do cliente
                            // seja bem vindo fulano, o que gostaria de fazer?...
                            AtividadesCliente();
                            //se nao informar que nao existe e mostrar novamente MostrarMenuCliente();
                            break;

                        case "2":
                            Console.Clear();
                            MostrarMenuInicial();
                            break;
                    }
                }
            } while (opcao != "0");
        }

        static void AtividadesCliente()
        {
            string opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("\t$$$$$$$$$$$$$$$  OPERAÇÕES BANCÁRIAS  $$$$$$$$$$$$$$$");
                Console.WriteLine("\t$$                                                 $$");
                Console.WriteLine("\t$$    opção 0 : MENU CLIENTE                       $$");
                Console.WriteLine("\t$$                                                 $$");
                Console.WriteLine("\t$$    opção 1 : depositar                          $$");
                Console.WriteLine("\t$$    opção 2 : sacar                              $$");
                Console.WriteLine("\t$$    opção 3 : transferir                         $$");
                Console.WriteLine("\t$$                                                 $$");
                Console.WriteLine("\t$$    opção 4 : extrato                            $$");
                Console.WriteLine("\t$$    opção 5 : saldo                              $$");
                Console.WriteLine("\t$$                                                 $$");
                Console.WriteLine("\t$$    opção 6 : realizar pagamento                 $$");
                Console.WriteLine("\t$$    opção 7 : solicitar emprestimo               $$");
                Console.WriteLine("\t$$                                                 $$");
                Console.WriteLine("\t$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");

                Console.Write("\n\tInforme a opcao: ");
                opcao = Console.ReadLine();

                if (opcao != "0" && opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5" && opcao != "6" && opcao != "7")
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
                            MostrarMenuCliente();
                            break;
                        case "1":
                            Console.Clear();

                            break;
                        case "2":
                            Console.Clear();

                            break;
                        case "3":
                            Console.Clear();

                            break;
                        case "4":
                            Console.Clear();

                            break;
                        case "5":
                            Console.Clear();

                            break;
                        case "6":
                            Console.Clear();

                            break;
                        case "7":
                            Console.Clear();

                            break;
                    }
                }
            } while (opcao != "0");
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

            Console.Write("estudante? (S/N) ");
            string estudante = Console.ReadLine().ToUpper();
            Console.Write("qual a renda? ");
            double renda = double.Parse(Console.ReadLine());

            Cliente cliente = new Cliente(estudante == "S" ? true : false, renda, RetornaNumeroConta(), pessoa);

            lstClientesPendentes.Add(cliente);

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