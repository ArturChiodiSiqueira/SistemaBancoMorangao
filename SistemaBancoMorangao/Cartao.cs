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
        public String ValidadeCartao { get; set; }

        public Cartao()
        {
            
        }

        public Cartao(string senha, double limite, double saldo, string numDoCartao, string dataDeVencFatura, string digVerificador, string validadeCartao)
        {
            HabilitarCredito = false;
            Senha = senha;
            Limite = limite;
            Saldo = saldo;
            NumDoCartao = numDoCartao;
            DataDeVencFatura = dataDeVencFatura;
            DigVerificador = digVerificador;
            ValidadeCartao = validadeCartao;
        }

        public override string ToString()
        {
            return "Número do Cartão: " + NumDoCartao + "\nDigito verificador: " + DigVerificador + "\nData vencimento da fatura: " + DataDeVencFatura + "\nData de vencimento do cartão: "+ ValidadeCartao + "\nLimite: " + Limite + "\nSaldo: " + Saldo.ToString("F2").ToString();
        }
    }
}
