using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades;
using Projeto.Entidades.Contratos;// Importando     
using Projeto.Entidades.Seguranca; // importando 

namespace Projeto.Entidades.Controles
{
    public class UsuarioControle
    {
        // método para ler e imprimir os dados do usuário
        public void Executar()
        {
            try
            {
                // instânciando a entidade Usuario
                var u = new Usuario();

                //definindo um ID para o usuário
                u.IdUsuario = Guid.NewGuid();

                Console.Write("\n Informe seu login: ");
                u.Login = Console.ReadLine();

                Console.Write("\n Escolha [1]MD5 ou [2]SHA1: ");
                int opcao = int.Parse(Console.ReadLine());

                ICriptografia c = null;

                switch (opcao)
                {
                    case 1:
                        c = new CriptografiaMD5();//polimorfismo
                        break;

                    case 2:
                        c = new CriptografiaSHA1();//polimorfismo
                        break;

                    default:
                        Console.WriteLine("Valor incorreto !");
                        break;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Erro: "+ex.Message);
            }
        }
    }
}
