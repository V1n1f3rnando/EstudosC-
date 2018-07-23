using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EstudosPOOPt1.Controles
{
    public class Inicio
    {
        public Inicio()
        {
           
        }
        public static void Menu()
        {
            Console.WriteLine("\n ---- CONTROLE DE PESSOAS ---- \n");

            Console.WriteLine("(1) Cadastrar");
            Console.WriteLine("(2) Alterar");
            Console.WriteLine("(3) Excluir");
            Console.WriteLine("(4) Listar Todos");
            Console.WriteLine("(5) Buscar Po Id");
            Console.WriteLine("(6) Sair");

            Console.Write("\n Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());

            var Pc = new PessoaControle();

            switch (opcao)
            {
                case 1:
                    Pc.CadastrarPessoa();
                    break;

                case 2:
                    Pc.AlterarPessoa();
                    break;

                case 3:
                    Pc.DeletarPessoa();
                    break;

                case 4:
                    Pc.ConsultarPessoas();
                    break;

                case 5:
                    Pc.BuscarPessoaPorId();
                    break;

                case 6:
                    Environment.Exit(1);
                    break;

                default:
                    Console.WriteLine("Opção inválida !!");
                    break;
            }
        }
      
}
}
