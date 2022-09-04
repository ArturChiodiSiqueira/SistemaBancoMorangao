using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancoMorangao
{
    public class Pessoa
    {
        public String Nome { get; set; }
        public String Telefone { get; set; }
        public String Email { get; set; }
        public String Cpf { get; set; }
        public char Genero { get; set; }
        public Endereco Endereco { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(string nome, string telefone, string email, string cpf, char genero)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Cpf = cpf;
            Genero = genero;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + "\nTelefone: " + Telefone + "\nEmail: " + Email + "\nCpf: " + Cpf + "\nGenero: " + Genero + "\nEndereço: " + Endereco.ToString();
        }
    }
}
