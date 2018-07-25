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
            var uc = new UsuarioControle();
            uc.Executar();

            Console.ReadKey();
        }
    }
}
