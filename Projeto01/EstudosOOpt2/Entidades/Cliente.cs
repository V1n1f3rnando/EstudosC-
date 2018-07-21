using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosOOpt2.Entidades
{
    public class Cliente
    {
        //Atributos privates, acesso somente dentro da classe.
        private int idCliente;
        private string nome;
        private string email;

        //Métodos..
        //encapsulamento (set [entrada], get [saída])
        public int IdCliente
        {
            set { idCliente = value; } //Entrada
            get { return idCliente; } //saída
        }

        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }

        public string Email
        {
            set { email = value; }
            get { return email; }
        }

    }
}
