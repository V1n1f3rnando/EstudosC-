using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades;
using Projeto.Entidades.Servicos;
using System.Net; // importando 
using System.Net.Mail; //importando 


namespace Entidades_do_Sistema
{
    public class MensagemService : IMensagemService
    {
        public void EnviarMensagem(Mensagem msg)
        {
            //conta de email
            string contaEmail = "estudoscsharp.teste@gmail.com";
            string senha = "Bg@123456789";

            //enviando o email 
            MailMessage email = new MailMessage(contaEmail, msg.EmailDestino);
            email.Subject = msg.Assunto;
            email.Body = msg.Conteudo;

            //Enviando o email
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true; //Habilitando criptografia SSL
            smtp.Credentials = new NetworkCredential(contaEmail, senha);

            //Finalizando 
            smtp.Send(email);


        }
    }
}
