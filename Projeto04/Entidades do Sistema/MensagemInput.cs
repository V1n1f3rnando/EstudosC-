using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_do_Sistema
{
    public class MensagemInput
    {
        public static string LerEmailDestino()
        {
            Console.WriteLine("Informe o email de destino: ");
            return Console.ReadLine();
        }

        public static string LerAssunto()
        {
            Console.WriteLine("Informe o assunto da mensagem: ");
            return Console.ReadLine();
        }

        public static string LerConteudo()
        {
            Console.WriteLine("Informe o conteudo da mensagem: ");
            return Console.ReadLine();
        }

    }
}
