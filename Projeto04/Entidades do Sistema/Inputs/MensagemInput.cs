using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entidades.Inputs
{
    public class MensagemInput
    {
        //Método para ler o email do destinatario
        public static string LerEmailDestino()
        {
            Console.Write("\n Informe o email de destino: ");
            return Console.ReadLine();
        }

        //Método para ler assunto..
        public static string LerAssunto()
        {
            Console.Write("\n Informe o assunto da mensagem: ");
            return Console.ReadLine();
        }

        //Método para ler o conteudo..
        public static string LerConteudo()
        {
            Console.Write("\n Informe o conteudo da mensagem: ");
            return Console.ReadLine();
        }

    }
}
