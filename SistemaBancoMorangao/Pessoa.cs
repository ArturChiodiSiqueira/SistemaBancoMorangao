﻿using System;
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
            Console.Write("Informe seu nome completo: ");
            Nome = Console.ReadLine();

            Console.Write("Informe seu telefone/celular: ");
            Telefone = Console.ReadLine();

            Console.Write("Informe seu Email: ");
            Email = Console.ReadLine();

            Console.Write("Informe seu CPF: ");
            Cpf = Console.ReadLine();

            Console.Write("Informe seu genero (M ou F): ");
            Genero = char.Parse(Console.ReadLine().ToUpper());

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
