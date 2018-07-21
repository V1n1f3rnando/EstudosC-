using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosOOpt3.Entidades
{
    public abstract class Pessoa // Classe abstrata, usada como classe modelo, pode conter métodos abstratos.
    {
        private int idPessoa;
        private string nome;

        public int IdPessoa
        {
            set { idPessoa = value; }
            get { return idPessoa; }
        }

        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }
    }
}
