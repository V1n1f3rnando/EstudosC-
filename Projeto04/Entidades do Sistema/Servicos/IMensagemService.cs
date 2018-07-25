using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades;

namespace Projeto.Entidades.Servicos
{
    public interface IMensagemService
    {
        //Método abstrato 
        void EnviarMensagem(Mensagem msg);
    }
}
