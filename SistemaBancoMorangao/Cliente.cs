using SistemaBancoMorangao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancoMorangao
{
    public enum TipoConta
    {
        Estudante,
        Normal,
        Vip
    }

    public enum Status
    {
        Pendente,
        Aprovado,
        Cancelado
    }

    public class Cliente
    {
        internal const double RENDA_MINIMA = 5000;

        internal TipoConta _tipo;
        internal double _renda;
        internal Status _status;

        //public Status Status
        //{
        //    set
        //    {
        //        _status = Status.Aprovado;
        //    }
        //}

        public void AtualizaStatus()
        {
            _status = Status.Aprovado;
        }

        public TipoConta Tipo
        {
            get
            {
                return _tipo;
            }
        }
        public bool Habilitacao { get; set; }
        public double Renda
        {
            get
            {
                return _renda;
            }
        }
        public bool Estudante { get; set; }
        public int Conta { get; set; }
        public Pessoa Pessoa { get; set; }

        public Cliente()
        {

        }

        public Cliente(bool estudante, double renda, int conta, Pessoa pessoa)
        {
            Estudante = estudante;
            _renda = renda;
            Conta = conta;
            this.Pessoa = pessoa;

            AtualizaTipo();
        }

        public void AtualizaRenda(double renda)
        {
            _renda = renda;

            AtualizaTipo();
        }

        internal void AtualizaTipo()
        {
            if (Renda >= RENDA_MINIMA)
                _tipo = TipoConta.Vip;

            else if (Estudante == true)
                _tipo = TipoConta.Estudante;

            else
                _tipo = TipoConta.Normal;
        }

        public override string ToString()
        {
            return Pessoa.ToString() + "\nEstudante: " + Estudante + "\nRenda: " + Renda + "\nConta: " + Conta;
            //return pessoa.ToString() + "\nhabilitacao: " + Habilitacao + "\nEstudante: " + Estudante + "\nRenda: " + Renda + "\nConta: " + Conta;
        }
    }
}

