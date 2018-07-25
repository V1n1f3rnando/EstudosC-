using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades;
using Projeto.Entidades.Inputs;
using Projeto.Entidades.Servicos;

namespace Projeto.Entidades.Controles
{
    public class MensagemControle
    {
        public void ExecutarEnvioDeMensagem()
        {
            try
            {
                Mensagem msg = new Mensagem();

                msg.EmailDestino = MensagemInput.LerEmailDestino();
                msg.Assunto = MensagemInput.LerAssunto();
                msg.Conteudo = MensagemInput.LerConteudo();

                //Enviando a mensagem
                MensagemService svc = new MensagemService();
                svc.EnviarMensagem(msg);

                Console.WriteLine("\n Mensagem enviada com sucesso !!");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Erro: "+ex.Message);
            }
        }
    }
}
