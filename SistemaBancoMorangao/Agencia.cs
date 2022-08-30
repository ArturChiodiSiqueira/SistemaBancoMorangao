using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancoMorangao
{
    internal class Agencia
    {
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
