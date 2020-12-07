using System;
using Codigo.Classes;

namespace Codigo
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
            PessoaJuidica pj = new PessoaJuidica();

            pf.cpf = "000.000.000-00";
            pf.nome = "nome";
        }
    }
}
           