using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudosPOOPt1.Controles;

namespace EstudosPOOPt1
{
    class Program
    {
        static void Main(string[] args)
        {
            var tela = new Inicio();

            tela.Menu();

            Console.ReadKey();
        }
    }
}
