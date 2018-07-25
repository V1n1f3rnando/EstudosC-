using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades.Controles;


namespace EstudosOO
{
    class Program
    {
        static void Main(string[] args)
        {
            MensagemControle mc = new MensagemControle();
            mc.ExecutarEnvioDeMensagem();

            Console.ReadKey();
        }
    }
}
