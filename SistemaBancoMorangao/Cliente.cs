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

    internal class Cliente
    {
        internal const double RENDA_MINIMA = 5000;
        internal TipoConta _tipo;
        internal protected double _renda;
        internal Status _status;
        public bool Habilitacao { get; set; }
        public bool Estudante { get; set; }
        public ContaCorrente Conta { get; set; }
        public Pessoa Pessoa { get; set; }

        public Cliente()
        { }

        public Cliente(bool estudante, double renda, Pessoa pessoa)
        {
            Estudante = estudante;
            _renda = renda;
            this.Pessoa = pessoa;

            AtualizaTipo();
        }

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

        public double Renda
        {
            get
            {
                return _renda;
            }
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
            return Pessoa.ToString() + "\nEstudante: " + Estudante + "\nRenda: " + Renda + "\nConta: " + Conta.NumConta + "\nTipo da Conta: " + Tipo;
        }
    }
}