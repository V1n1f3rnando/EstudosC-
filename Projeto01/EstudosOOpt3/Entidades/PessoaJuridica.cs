using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosOOpt3.Entidades
{
    public class PessoaJuridica : Pessoa // Herança, digo que PessoaJuridica É UMA PESSOA 
    {
        private string cnpj;

        public string Cnpj
        {
            set { cnpj = value; }
            get { return cnpj; }
        }
    }
}
