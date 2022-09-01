using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancoMorangao
{
    internal class Funcionario
    {
        public Pessoa pessoa { get; set; }
        public String IdFuncionario { get; set; }
        public String Cargo { get; set; }
        public String NiveldeAcesso { get; set; }

        public Funcionario()
        {
            pessoa = new Pessoa();

            Console.Write("Informe o ID do funcionário: ");
            IdFuncionario = Console.ReadLine();

            Console.Write("Informe o cargo do funcionário: ");
            Cargo = Console.ReadLine();

            Console.Write("Informe o nivel de acesso do funcionário: ");
            NiveldeAcesso = Console.ReadLine();
        }

        //public Funcionario(Pessoa pessoa, string idFuncionario, string cargo, string niveldeAcesso)
        //{
        //    this.pessoa = pessoa;
        //    IdFuncionario = idFuncionario;
        //    Cargo = cargo;
        //    NiveldeAcesso = niveldeAcesso;
        //}

        public override string ToString()
        {
            return pessoa.ToString() + "\nID do Funcionário: " + IdFuncionario + "\nCargo: " + Cargo + "\nNivel de Acesso: " + NiveldeAcesso;
            
        }
    }
}
