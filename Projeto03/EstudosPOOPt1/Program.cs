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
            Console.WriteLine("\n ---- CONTROLE DE PESSOAS ---- \n");

            Console.WriteLine("(1) Cadastrar");
            Console.WriteLine("(2) Alterar");
            Console.WriteLine("(3) Excluir");
            Console.WriteLine("(4) Listar Todos");
            Console.WriteLine("(5) Buscar Po Id");

            Console.WriteLine("\n Escolha uma opção.");
            int opcao = int.Parse(Console.ReadLine());

            var Pc = new PessoaControle();

            switch (opcao)
            {
                case 1:
                    Pc.CadastrarPessoa();
                    break;

                default:
                    Console.WriteLine("Opção inválida !!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
