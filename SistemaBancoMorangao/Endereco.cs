using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancoMorangao
{
    public class Endereco
    {
        public String Logradouro { get; set; }
        public String Numero { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public String Cep { get; set; }
        public String Complemento { get; set; }

        public Endereco()
        {

        }

        public Endereco(string logradouro, string numero, string bairro, string cidade, string cep, string complemento)
        {
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Cep = cep;
            Complemento = complemento;
        }

        public override string ToString()
        {
            return "Logradouro: " + Logradouro + "\nNumero: " + Numero + "\nBairro: " + Bairro + "\nCidade: " + Cidade + "\nCep: " + Cep + "\nComplemento: " + Complemento;
        }
    }
}
