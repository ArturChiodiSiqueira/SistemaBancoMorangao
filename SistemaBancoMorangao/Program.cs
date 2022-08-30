using System;

namespace SistemaBancoMorangao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PedeDadosCadastrais();
        }

        static void PedeDadosCadastrais()
        {
            Pessoa pessoa = new Pessoa();
            Console.WriteLine("\n" + pessoa);
        }
    }
}
