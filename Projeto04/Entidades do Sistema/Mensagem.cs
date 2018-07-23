using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entidades
{
    public class Mensagem
    {
        public Guid IdMensagem { get; set; }
        public string EmailDestino { get; set; }
        public string Assunto { get; set; }
        public string Conteudo { get; set; }

        public Mensagem()
        {

        }

        public Mensagem(Guid idMensagem, string emailDestino, string assunto, string conteudo)
        {
            IdMensagem = idMensagem;
            EmailDestino = emailDestino;
            Assunto = assunto;
            Conteudo = conteudo;
        }

        public override string ToString()
        {
            return string.Format("ID:{0}, Para:{1}, Assunto:{2}, Conteúdo{3}", IdMensagem, EmailDestino, Assunto, Conteudo);
        }
    }
}
