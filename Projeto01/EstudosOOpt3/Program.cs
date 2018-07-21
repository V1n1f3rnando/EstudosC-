using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudosOOpt3.Entidades;

namespace EstudosOOpt3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instânciando a entidade PessoaFisica
            var pf = new PessoaFisica();

            pf.IdPessoa = 1;
            pf.Nome = "Vinicius";
            pf.Cpf = "1234567891-0";

            Console.Write("\n ID:"+pf.IdPessoa);
            Console.Write("\n Nome: "+pf.Nome);
            Console.Write("\n Cpf: "+pf.Cpf);

            Console.ReadKey();

        }
    }
}
