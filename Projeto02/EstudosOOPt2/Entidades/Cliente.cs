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

        //Construtor
        public Cliente()
        {

        }

        //Sobrecarregando o construtor 
        public Cliente(int idCliente, string nome, string email)
        {
            IdCliente = idCliente;
            Nome = nome;
            Email = email;
        }

        //Sobrecarregando o método ToString da classe Object
        public override string ToString()
        {
            return $"\n ID: {IdCliente}\n Nome:{Nome}\n Email:{Email}";
        }
    }
}
