using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancoMorangao
{
    internal class Pessoa
    {
        public String Nome { get; set; }
        public String Telefone { get; set; }
        public String Email { get; set; }
        public String Cpf { get; set; }
        public char Genero { get; set; }
        public Endereco endereco { get; set; }

        public Pessoa()
        {
            Console.WriteLine("Informe o Nome: ");
            Nome = Console.ReadLine();

            Console.WriteLine("Informe o Telefone: ");
            Telefone = Console.ReadLine();

            Console.WriteLine("Informe o Email: ");
            Email = Console.ReadLine();

            Console.WriteLine("Informe o CPF: ");
            Cpf = Console.ReadLine();

            Console.WriteLine("Informe o Genero: ");
            Genero = char.Parse(Console.ReadLine());

            endereco = new Endereco();
        }

        //public Pessoa(string nome, string telefone, string email, string cpf, char genero)
        //{
        //    Nome = nome;
        //    Telefone = telefone;
        //    Email = email;
        //    Cpf = cpf;
        //    Genero = genero;
        //}

        public override string ToString()
        {
            return "Nome: " + Nome + "\nTelefone: " + Telefone + "\nEmail: " + Email + "\nCpf: " + Cpf + "\nGenero: " + Genero + "\nEndereço: " + endereco.ToString();
        }
    }
}
