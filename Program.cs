using System;

namespace AulaPOOCPF
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa thiago = new Pessoa();
            thiago.nome = "Thiago Nunes";
            System.Console.WriteLine(thiago.Saudar());

            CPF meusdocs = new CPF();
            meusdocs.cpf = "111.111.111-11";
            System.Console.WriteLine(meusdocs.ValidarCPF(meusdocs.cpf));
            meusdocs.rg = "11.111.111-1";
            System.Console.WriteLine(meusdocs.ValidarRG(meusdocs.rg));

            CNPJ meucnpj = new CNPJ();
            meucnpj.cnpj = "00.000.000/0000-00";
            System.Console.WriteLine(meucnpj.ValidarCNPJ(meucnpj.cnpj));



        }
    }
}
