using System;

namespace SistemaBancoMorangao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "SISTEMA BANCO MORANGÃO";

            MostrarMenu();
        }

        static void MostrarMenu()
        {
            string opcao;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nDENTRE AS OPÇÕES NO MENU, QUAL DESEJA EXECUTAR?\n");
                Console.WriteLine("\t|°°°°°°°°°°°°°°°°°  MENU  °°°°°°°°°°°°°°°°°°|");
                Console.WriteLine("\t|   opção 0 : sair                          |");
                Console.WriteLine("\t|                                           |");
                Console.WriteLine("\t|   opção 1 : solicitar abertura de conta   |");
                Console.WriteLine("\t|                                           |");
                Console.WriteLine("\t|   opção 2 : entrar                        |");
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
                            PedeDadosCadastrais();
                            break;

                        case "2":
                            Console.Clear();
                            break;
                    }
                }
            } while (opcao != "0");
        }

        static void PedeDadosCadastrais()
        {
            Pessoa pessoa = new Pessoa();
            Console.WriteLine("\n" + pessoa);
            Console.ReadKey();
        }
    }
}
