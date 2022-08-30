using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancoMorangao
{
    internal class Cartao
    {
        public String HabilitarCredito { get; set; }
        public String Senha { get; set; }
        public String Limite { get; set; }
        public String Saldo { get; set; }
        public String NumDoCartao { get; set; }
        public String DataDeVencFatura { get; set; }
        public String DigVerificador { get; set; }
        public String ValidadeCartao { get; set; }

        public Cartao()
        {

        }

        public Cartao(string habilitarCredito, string senha, string limite, string saldo, string numDoCartao, string dataDeVencFatura, string digVerificador, string validadeCartao)
        {
            HabilitarCredito = habilitarCredito;
            Senha = senha;
            Limite = limite;
            Saldo = saldo;
            NumDoCartao = numDoCartao;
            DataDeVencFatura = dataDeVencFatura;
            DigVerificador = digVerificador;
            ValidadeCartao = validadeCartao;
        }
    }
}
