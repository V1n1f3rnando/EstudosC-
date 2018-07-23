using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosPOOPt1.Entidades
{
    public class Pessoa
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public DateTime DataNasc { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(int idPessoa, string nome, DateTime dataNasc)
        {
            IdPessoa = idPessoa;
            Nome = nome;
            DataNasc = dataNasc;
        }

        public override string ToString()
        {
            return string.Format("ID:{0}, Nome:{1}, Data Nascimento:{2}", IdPessoa, Nome, DataNasc);
        }
    }
}
