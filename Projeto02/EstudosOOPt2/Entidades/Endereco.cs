using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosOOPt2.Entidades
{
    public class Endereco
    {
        public int IdEndereco { get; set; }
        public string Logradouro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }

        //Relacionamento associação 1 p 1
        public Cliente Cliente { get; set; }

        public Endereco()
        {

        }

        public Endereco(int idEndereco, string logradouro, string cidade, string estado, string cep)
        {
            IdEndereco = idEndereco;
            Logradouro = logradouro;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
        }

        public override string ToString()
        {
            return $"Endereço: {IdEndereco}, {Logradouro}, {Cidade}, {Estado}, {Cep} ";
        }

    }
}
