using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancoMorangao
{
    internal class ContaPoupanca : ContaCorrente
    {
        public double Saldo { get; set; }

        public ContaPoupanca() : base()
        {
            Saldo = 0;
        }

        public override string ToString()
        {
            return "\n>>>POUPANÇA<<<\nSaldo: " + Saldo.ToString("F").ToString();
        }
    }
}
