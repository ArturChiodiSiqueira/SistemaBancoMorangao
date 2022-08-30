using System;

namespace SistemaBancoMorangao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PedeDadosEndereco();
        }

        static void PedeDadosEndereco()
        {
            Endereco endereco = new Endereco();
            Console.WriteLine("\n" + endereco);
        }
    }
}
