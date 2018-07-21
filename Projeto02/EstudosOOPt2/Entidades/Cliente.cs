using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosOOPt2.Entidades
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        //Relacionamento de Associação (TER-1)
        public Endereco Endereco { get; set; }

        public Cliente()
        {

        }

        //Sobrecarga de construtor 
        public Cliente(int idCliente, string nome, string email)
        {
            IdCliente = idCliente;
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return string.Format("Cliente: {0}, {1}, {2}", IdCliente, Nome, Email);
        }
    }
}
