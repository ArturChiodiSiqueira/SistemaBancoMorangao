﻿using System;
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
        }

        public Funcionario(Pessoa pessoa, string idFuncionario, string cargo, string niveldeAcesso)
        {
            this.pessoa = pessoa;
            IdFuncionario = idFuncionario;
            Cargo = cargo;
            NiveldeAcesso = niveldeAcesso;
        }
    }
}
