using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudosPOOPt1.Entidades;
using EstudosPOOPt1.Repositorios;
using EstudosPOOPt1.Controles;

namespace EstudosPOOPt1.Controles
{
    public class PessoaControle : Inicio
    {
       public void CadastrarPessoa()
        {
            Console.WriteLine("\n - CADASTRO DE PESSOA \n ");

            try
            {
                //Instânciando a entidade Pessoa
                var p = new Pessoa();
                Console.Write("Informe o nome: ");
                p.Nome = Console.ReadLine();

                Console.Write("Informe a data de Nasc:");
                p.DataNasc = DateTime.Parse(Console.ReadLine());

                //Instânciando a entidade PessoaRepositorio
                var rep = new PessoaRepositorio();
                rep.Cadastrar(p);

                Console.WriteLine("\n Pessoa cadastrada com sucesso ! \n");
                Console.Write("Digite 1- Novo cadastro 2- Voltar ao menu 3- Sair:");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        CadastrarPessoa();
                        break;

                    case 2:
                        Console.Clear();
                        Menu();
                        break;

                    case 3:
                        Environment.Exit(1);
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

       public void DeletarPessoa()
        {
            Console.WriteLine("\n - DELETAR PESSOA - \n");

            Console.Write("\n Informe o id da pessoa que deseja deletar: ");
            int id = int.Parse(Console.ReadLine());

            try
            {
                var rep = new PessoaRepositorio();

                if (rep.BuscarPessoaPoId(id) != null)
                {
                    string resultado = rep.BuscarPessoaPoId(id).ToString();

                    Console.WriteLine("\n Informações: " + resultado);
                    Console.Write("\n Deseja excluir ?: s/n: ");
                    char opcao = char.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 's':
                            rep.DeletarPessoa(id);
                            Console.WriteLine("\n Pessoa deletada com sucesso !!");
                            break;

                        case 'n':
                            Console.Clear();
                            Menu();
                            break;

                        default:
                            Console.WriteLine("\n Valor inválido !! preciso uma tecla para voltar ao menu.");
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\n  Valor inválido verifique o id digitado..");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                }
               
            }
            catch (Exception ex)
            {

                Console.WriteLine("Erro !!"+ex.Message);
            }


        }

       public void AlterarPessoa()
        {
            Console.WriteLine("\n - ALTERAR PESSOA - \n");

            Console.Write("Informe o id da pessoa que você deseja alterar os dados: ");
            int id = int.Parse(Console.ReadLine());

            try
            {
                var rep = new PessoaRepositorio();

                if (rep.BuscarPessoaPoId(id) != null)
                {
                    var p = new Pessoa();

                    p.IdPessoa = id;
                    Console.WriteLine("Dados atuais: " + rep.BuscarPessoaPoId(id) + "\n");
                    Console.Write("\n Informe o nome desejado: ");
                    p.Nome = Console.ReadLine();
                    Console.Write("\n Informe a data de nascimento: ");
                    p.DataNasc = DateTime.Parse(Console.ReadLine());

                    rep.Alterar(p);

                    Console.WriteLine("\n Dados alterados com sucesso ! pressione uma tecla para voltar ao menu.");
                    Console.ReadKey();

                    Console.Clear();
                    Menu();

                }
                else
                {
                    Console.WriteLine("\n Valor inválido verifique o id digitado..");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Erro !!"+ex.Message);
            }
            
        }

       public void ConsultarPessoas()
        {
            Console.WriteLine("\n - PESSOAS CADASTRADAS - \n");

            try
            {
                var rep = new PessoaRepositorio();

                //Pecorrendo a lista para montar o resultado 
                foreach (var p in rep.ConsultarPessoa())
                {
                  
                    Console.WriteLine("\n " +p);
                    
                }
                Console.WriteLine("\n Resultados: " + rep.ConsultarPessoa().Count() + "\n");

                Console.Write("Deseja voltar ao menu ? s/n: ");
                char opcao = char.Parse(Console.ReadLine());

                if (opcao == 's')
                {
                    
                    Console.Clear();
                    Menu();

                }
                else
                {
                    Environment.Exit(1);
                }


                Console.WriteLine("\n Busca realizada com sucesso ! \n");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }   
         
        }

       public void BuscarPessoaPorId()
        {
            Console.WriteLine("\n - Buscar pessoa por ID - \n");

            Console.Write("\n Informe o id da pessoa:");
            int id = int.Parse(Console.ReadLine());

            try
            {
                var rep = new PessoaRepositorio();

                Console.WriteLine("\n Dados solicitados: \n"+ rep.BuscarPessoaPoId(id)); 
            }
            catch (Exception ex)
            {

                Console.WriteLine("Erro !"+ex.Message);
            }
            

        }
        


    }
}
