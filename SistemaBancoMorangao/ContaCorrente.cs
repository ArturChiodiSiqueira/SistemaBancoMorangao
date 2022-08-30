using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancoMorangao
{
    internal class ContaCorrente
    {
        public String Habilitada { get; set; }
        public Cliente cliente { get; set; }
        public Agencia agencia { get; set; }
        public String Senha { get; set; }
        public String NumConta { get; set; }
        public String Saldo { get; set; }
        public String Limite { get; set; }
        public String Cartao { get; set; }
        public String TipoConta { get; set; }
    }
}
