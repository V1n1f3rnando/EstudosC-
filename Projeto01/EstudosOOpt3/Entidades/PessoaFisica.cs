using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosOOpt3.Entidades
{
    public class PessoaFisica : Pessoa // Herança, digo que PessoaFisica É UMA PESSOA 
    {
        private string cpf;

        //Construtor da classe 
        public PessoaFisica()
        {

        }

        public string Cpf
        {
            set { cpf = value; }
            get { return cpf; }
        }
    }
}
