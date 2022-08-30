using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancoMorangao
{
    internal class Cliente
    {
        public bool Habilitacao { get; set; }
        public bool Estudante { get; set; }
        public double Renda { get; set; }
        public int Conta { get; set; }
        public Pessoa pessoa { get; set; }

        public Cliente()
        {
            Console.WriteLine("Informe a habilitacao: ");
            Habilitacao = bool.Parse(Console.ReadLine());

            Console.WriteLine("Informe se é estudante: ");
            Estudante = bool.Parse(Console.ReadLine());

            Console.WriteLine("Informe a Renda: ");
            Renda = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a conta: ");
            Conta = int.Parse(Console.ReadLine());

            pessoa = new Pessoa();
        }

        //public Cliente(bool habilitacao, bool estudante, double renda, int conta, Pessoa pessoa)
        //{
        //    Habilitacao = habilitacao;
        //    Estudante = estudante;
        //    Renda = renda;
        //    Conta = conta;
        //    this.pessoa = pessoa;
        //}

        public override string ToString()
        {
            return "hablitacao: " + Habilitacao + "\nEstudante: " + Estudante + "\nRenda: " + Renda + "\nConta: " + Conta;
        }
    }
}
