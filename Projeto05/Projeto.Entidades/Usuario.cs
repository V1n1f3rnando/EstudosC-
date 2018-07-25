using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entidades
{
    public class Usuario
    {
        //Encapsulamento inplícito 
        public Guid IdUsuario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        //Construtor
        public Usuario()
        {

        }

        //Sobrecarga de construtor 
        public Usuario(Guid idUsuario, string login, string senha)
        {
            IdUsuario = idUsuario;
            Login = login;
            Senha = senha;
        }

        //Sobrescrita do método ToString da classe object
        public override string ToString()
        {
            return string.Format("ID:{0}, Login:{1}, Senha:{2}", IdUsuario, Login, Senha);
        }
    }
}
