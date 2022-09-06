using System;

namespace SistemaBancoMorangao
{
    internal class Funcionario
    {
        public Pessoa pessoa { get; set; }
        public int IdFuncionario { get; set; }
        public String Cargo { get; set; }
        public int NiveldeAcesso { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(Pessoa pessoa, int idFuncionario, string cargo, int niveldeAcesso)
        {
            this.pessoa = pessoa;
            IdFuncionario = idFuncionario;
            Cargo = cargo;
            NiveldeAcesso = niveldeAcesso;
        }

        public override string ToString()
        {
            return pessoa.ToString() + "\nID do Funcionário: " + IdFuncionario + "\nCargo: " + Cargo + "\nNivel de Acesso: " + NiveldeAcesso;

        }
    }
}
