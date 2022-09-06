using System;

namespace SistemaBancoMorangao
{
    internal class ContaCorrente
    {
        public bool Habilitada { get; set; }
        public Cliente cliente { get; set; }
        public int agencia { get; set; }
        public String Senha { get; set; }
        public String NumConta { get; set; }
        public double Saldo { get; set; }
        public double Limite { get; set; }
        public Cartao Cartao { get; set; }
        public String TipoConta { get; set; }

        public ContaCorrente()
        {

        }

        public ContaCorrente(Cliente cliente, int agencia, string senha, string numConta, double saldo, double limite, string tipoConta)
        {
            this.Habilitada = false;
            this.cliente = cliente;
            this.agencia = agencia;
            Senha = senha;
            NumConta = numConta;
            Saldo = saldo;
            Limite = CalcularLimite(cliente.Renda);
            Cartao = new Cartao(senha, limite, saldo, numConta);
            TipoConta = tipoConta;
        }

        static double CalcularLimite(double renda)
        {
            return renda * 0.3;
        }
    }
}
