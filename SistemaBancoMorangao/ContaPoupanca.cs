using System;

namespace SistemaBancoMorangao
{
    internal class ContaPoupanca : ContaCorrente
    {
        public ContaPoupanca()
        {
            Saldo = 0;
        }

        public void DepCp(double valor)
        {
            Saldo += valor;
        }

        public void SaqCp(double valor)
        {
            if (Saldo < valor)
            {
                Console.WriteLine("Não foi possivel realizar a operação.\nMotivo: Saldo Insuficiente.");
            }
            else
            {
                Saldo -= valor;
            }
        }

        public override string ToString()
        {
            return "\n>>>POUPANÇA<<<\nSaldo: " + Saldo.ToString("F2").ToString();
        }
    }
}
