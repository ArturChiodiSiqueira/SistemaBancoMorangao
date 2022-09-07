using System;
using System.Collections.Generic;

namespace SistemaBancoMorangao
{
    internal class Agencia
    {
        public List<Cliente> lstClientesPendentes = new List<Cliente>();
        public List<Cliente> lstClientesAprovados = new List<Cliente>();
        public List<Funcionario> lstFuncionarios = new List<Funcionario>();

        public List<int> lstNumeroContas = new List<int>();
        public List<int> lstIdFuncionarios = new List<int>();

        public String Agencias { get; set; }
        public String Clientes { get; set; }
        public String Funcionarios { get; set; }

        public Agencia()
        {

        }

        public Agencia(string agencias, string clientes, string funcionarios)
        {
            Agencias = agencias;
            Clientes = clientes;
            Funcionarios = funcionarios;
        }
    }
}