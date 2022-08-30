using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancoMorangao
{
    internal class ContaCorrente
    {
        public String Habilitada { get; set; }
        public Cliente cliente { get; set; }
        public Agencia agencia { get; set; }
        public String Senha { get; set; }
        public String NumConta { get; set; }
        public String Saldo { get; set; }
        public String Limite { get; set; }
        public String Cartao { get; set; }
        public String TipoConta { get; set; }

        public ContaCorrente()
        {

        }

        public ContaCorrente(string habilitada, Cliente cliente, Agencia agencia, string senha, string numConta, string saldo, string limite, string cartao, string tipoConta)
        {
            Habilitada = habilitada;
            this.cliente = cliente;
            this.agencia = agencia;
            Senha = senha;
            NumConta = numConta;
            Saldo = saldo;
            Limite = limite;
            Cartao = cartao;
            TipoConta = tipoConta;
        }
    }
}
