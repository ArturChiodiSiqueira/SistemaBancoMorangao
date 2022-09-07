using System;

namespace SistemaBancoMorangao
{
    internal class Cartao
    {
        public bool HabilitarCredito { get; set; }
        public String Senha { get; set; }
        public double Limite { get; set; }
        public double Saldo { get; set; }
        public String NumDoCartao { get; set; }
        public String DataDeVencFatura { get; set; }
        public String DigVerificador { get; set; }
        public DateTime ValidadeCartao { get; set; }

        public Cartao()
        {

        }

        public Cartao(string senha, double limite, double saldo, string numDoCartao)
        {
            HabilitarCredito = false;
            Senha = senha;
            Limite = limite;
            Saldo = saldo;
            NumDoCartao = numDoCartao;
            DataDeVencFatura = "7";
            DigVerificador = "8";
            ValidadeCartao = DateTime.Now;
        }

        public override string ToString()
        {
            return "Número do Cartão: " + NumDoCartao + "\tDigito verificador: " + DigVerificador + "\nData vencimento da fatura: " + DataDeVencFatura + "\tData de vencimento do cartão: " + ValidadeCartao + "\nLimite: " + Limite + "\tSaldo: " + Saldo.ToString("F2").ToString();
        }
    }
}
