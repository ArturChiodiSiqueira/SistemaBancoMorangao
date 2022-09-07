using System;
using System.Collections.Generic;
using System.ComponentModel;

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
                            }
                            Console.WriteLine("FIM DA IMPRESSÃO.");
                            Console.WriteLine("-----------------");
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
                            }
                            Console.WriteLine("FIM DA IMPRESSÃO.");
                            Console.WriteLine("-----------------");
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

        static void VerAprovacoes()
        {
            string opcao;
            do
            {
                Console.WriteLine("         TIPOS DE APROVAÇÕES");
                Console.WriteLine("(1 - Abertura de Conta | 2 - Emprétimo)");
                Console.WriteLine("=======================================");

                Console.Write("\nEscolha o Tipo deAprovação ou tecle (3) para voltar ao MENU INICIAL: ");
                opcao = Console.ReadLine();

                if (opcao != "1" && opcao != "2" && opcao != "3")
                {
                    Console.WriteLine("'" + opcao + "' é uma opcao INVALIDA! Pressione QUALQUER TECLA!");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
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
                }
            } while (opcao != "1" && opcao != "2" && opcao != "3");
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
                            Console.WriteLine("PARA PROSSEGUIR NOS INFORME O NUMERO DA CONTA, A AGENCIA E A SENHA DO CLIENTE.");

                            Console.Write("\nInforme o numero da conta: ");
                            string numeroInformado = Console.ReadLine();

                            Console.Write("Informe o numero da agencia: ");
                            int agenciaInformada = int.Parse(Console.ReadLine());

                            Console.Write("Informe a senha: ");
                            string senhaInformada = Console.ReadLine();

                            Cliente clienteBuscado = BuscarCliente(numeroInformado, agenciaInformada, senhaInformada);

                            if (clienteBuscado != null)
                            {
                                AtividadesCliente(clienteBuscado);
                            }
                            else
                            {
                                Console.WriteLine("\nInformação inválida registrada!");
                            }
                            Console.ReadKey();
                            break;

                        case "2":
                            Console.Clear();
                            MostrarMenuInicial();
                            break;
                    }
                }
            } while (opcao != "0");
        }

        static Cliente BuscarCliente(string numeroInformado, int agenciaInformada, string senhaInformada)
        {
            foreach (Cliente cliente in lstClientesAprovados)
            {
                if ((cliente != null) && (cliente.Conta.NumConta == numeroInformado) && (cliente.Conta.agencia == agenciaInformada) && (cliente.Conta.Senha == senhaInformada))
                {
                    return cliente;
                }
            }
            return null;
        }

        static void AtividadesCliente(Cliente clienteBuscado)
        {
            string opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("\tBEM VINDO " + clienteBuscado.Pessoa.Nome + "! Este é seu menu de operações financeiras!!\n");
                Console.WriteLine("\t$$$$$$$$$$$$$$$  OPERAÇÕES FINANCEIRAS  $$$$$$$$$$$$$$$");
                Console.WriteLine("\t$$                                                   $$");
                Console.WriteLine("\t$$    opção 0 : MENU CLIENTE                         $$");
                Console.WriteLine("\t$$                                                   $$");
                Console.WriteLine("\t$$    opção 1 : depositar                            $$");
                Console.WriteLine("\t$$    opção 2 : sacar                                $$");
                Console.WriteLine("\t$$    opção 3 : transferir                           $$");
                Console.WriteLine("\t$$                                                   $$");
                Console.WriteLine("\t$$    opção 4 : extrato                              $$");
                Console.WriteLine("\t$$    opção 5 : saldo                                $$");
                Console.WriteLine("\t$$                                                   $$");
                Console.WriteLine("\t$$    opção 6 : realizar pagamento                   $$");
                Console.WriteLine("\t$$                                                   $$");
                Console.WriteLine("\t$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");

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
                            RealizarDeposito(clienteBuscado);
                            break;

                        case "2":
                            RealizarSaque(clienteBuscado);
                            break;

                        case "3":
                            Console.Clear();
                            RealizarTransferencia(clienteBuscado);
                            break;

                        case "4":
                            Console.Clear();
                            ConsultarExtrato(clienteBuscado);
                            break;

                        case "5":
                            RealizarConsultaSaldo(clienteBuscado);
                            break;

                        case "6":
                            RealizarPagamento(clienteBuscado);
                            break;
                    }
                }
            } while (opcao != "0");
        }

        static void RealizarDeposito(Cliente clienteBuscado)
        {
            Console.WriteLine("\n\n$$$-DEPOSITAR-$$$");

            Console.Write("\nInforme o valor que irá depositar R$ ");
            double valor = double.Parse(Console.ReadLine());

            clienteBuscado.Conta.DepositarValor("CC", "DEPOSITO", valor);

            Console.Write("\nDepósito efetuado");
            Console.ReadKey();
        }

        static void RealizarSaque(Cliente clienteBuscado)
        {
            Console.WriteLine("\n\n$$$-SACAR-$$$");

            Console.Write("\nInforme o valor que irá sacar R$ ");
            double valor = double.Parse(Console.ReadLine());

            clienteBuscado.Conta.SacarValor("CC", "SAQUE", valor);

            if (valor > clienteBuscado.Conta.Saldo)
            {
                Console.WriteLine("\nSaque efetuado");
                Console.WriteLine("Limite consumido");
            }
            Console.ReadKey();
        }

        static void RealizarPagamento(Cliente clienteBuscado)
        {
            Console.WriteLine("\n\n$$$-PAGAR-$$$");

            Console.Write("\nInforme o valor do pagamento R$ ");
            double valor = double.Parse(Console.ReadLine());

            clienteBuscado.Conta.SacarValor("CC", "PAGAMENTO", valor);

            if (valor > clienteBuscado.Conta.Saldo)
            {
                Console.WriteLine("\nPagamento efetuado");
                Console.WriteLine("Limite consumido");
            }
            Console.ReadKey();
        }

        static void RealizarTransferencia(Cliente clienteBuscado)
        {
            string opcao;
            do
            {
                Console.WriteLine("        TIPOS DE TRANSFERÊNCIA");
                Console.WriteLine("(1 - Para Poupança | 2 - Outra Conta  )");
                Console.WriteLine("0 - sair");
                Console.WriteLine("=======================================");

                Console.Write("\nInforme a opcao: ");
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
                            MostrarMenuCliente();
                            break;

                        case "1":
                            TranferirContaPoupanca(clienteBuscado);
                            break;

                        case "2":
                            TranferirOutraConta(clienteBuscado);
                            break;
                    }
                }
            } while (opcao != "0");
        }

        static void TranferirOutraConta(Cliente clienteBuscado)
        {

        }

        
        static void TranferirContaPoupanca(Cliente clienteBuscado)
        {
            string opcao;
            do
            {

                Console.WriteLine("        O que deseja fazer");
                Console.WriteLine("(1 - Adicionar | 2 - Remover          )");
                Console.WriteLine("0 - voltar");
                Console.WriteLine("=======================================");

                Console.Write("\nInforme a opcao: ");
                opcao = Console.ReadLine();

                if (opcao != "0" && opcao != "1" && opcao != "2")
                {
                    Console.WriteLine("'" + opcao + "' é uma opcao INVALIDA! Para voltar ao MENU, pressione QUALQUER TECLA!");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Informr o valor: ");
                    double valor = double.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case "0":
                            RealizarTransferencia(clienteBuscado);
                            break;
                        case "1":
                            if (clienteBuscado.Conta.SacarValor("CC", "Add Poupanca", valor) == 1)
                            {
                                clienteBuscado.Conta.contaPoupanca.DepositarValor("CP", "Transferencia", valor);
                            }
                            else
                            {
                                Console.WriteLine("solicitação invalida");
                            }
                            Console.ReadKey();
                            break;
                            
                        case "2":
                            if (clienteBuscado.Conta.contaPoupanca.SacarValor("CP", "Transferencia", valor) == 1)
                            {
                                clienteBuscado.Conta.DepositarValor("CC", "Transferencia", valor);
                            }
                            else
                            {
                                Console.WriteLine("solicitação invalida");
                            }
                            Console.ReadKey();

                            Console.WriteLine("Saldo Poupança: " + clienteBuscado.Conta.contaPoupanca.Saldo);
                            break;
                    }
                }
            } while (opcao != "0");
        }

        static void ConsultarExtrato(Cliente clienteBuscado)
        {
            Console.WriteLine("Dados do cliente: ");
            Console.WriteLine("Nome: " + clienteBuscado.Pessoa.Nome + "\t" +
            "Agência: " + clienteBuscado.Conta.agencia + "\t" +
            "Numero da conta: " + clienteBuscado.Conta.NumConta);
            Console.WriteLine("__________________________________________________________");
            clienteBuscado.Conta.ImprimeExtrato();
            RealizarConsultaSaldo(clienteBuscado);
        }

        static void RealizarConsultaSaldo(Cliente clienteBuscado)
        {
            Console.WriteLine("\n\n$$$-SALDO-$$$");

            Console.Write("Saldo atual: ");
            Console.WriteLine(clienteBuscado.Conta.Saldo);
            Console.Write("Saldo atual + Limite: ");
            Console.WriteLine(clienteBuscado.Conta.Saldo + clienteBuscado.Conta.Limite);

            Console.ReadKey();
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

            string cpf;
            do
            {
                Console.Write("Informe o CPF (11 digitos): ");
                cpf = Console.ReadLine();
            } while (cpf.Length != 11);

            char genero;
            do
            {
                Console.Write("Informe o genero (M ou F): ");
                genero = char.Parse(Console.ReadLine().ToUpper());
            } while (genero != 'M' && genero != 'F');

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
            Cliente cliente = new Cliente(estudante == "S" ? true : false, renda, pessoa);
            cliente.Conta = CadastrarConta(cliente);

            lstClientesPendentes.Add(cliente);

            Console.Clear();
            Console.WriteLine("Dados cadastrados:\n" + cliente);
            Console.WriteLine("\n\nSolicitação concluída!");
            Console.WriteLine("Aperte qualquer tecla para voltar!");
            Console.ReadKey();
            MostrarMenuInicial();
        }

        static ContaCorrente CadastrarConta(Cliente cliente)
        {
            Console.Write("\nInforme a SENHA: ");
            string senha = Console.ReadLine();

            int numeroConta = RetornaNumeroConta();

            Console.Write("Informe o numero da AGENCIA: ");
            int agencia = int.Parse(Console.ReadLine());

            Console.Write("\nCaso NÃO tenha depósito inicial digite 0, caso TENHA digite o valor: ");
            double saldo = double.Parse(Console.ReadLine());

            return new ContaCorrente(cliente, agencia, senha, numeroConta.ToString(), saldo);
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

            string cpf;
            do
            {
                Console.Write("Informe o CPF (11 digitos): ");
                cpf = Console.ReadLine();
            } while (cpf.Length != 11);

            char genero;
            do
            {
                Console.Write("Informe o genero (M ou F): ");
                genero = char.Parse(Console.ReadLine().ToUpper());
            } while (genero != 'M' && genero != 'F');

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

            int niveldeAcesso;
            do
            {
                Console.Write("Informe o nivel de acesso do funcionário (1 - funcionario | 2 - gerente): ");
                niveldeAcesso = int.Parse(Console.ReadLine());
            } while (niveldeAcesso != 1 && niveldeAcesso != 2);

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
    }
}