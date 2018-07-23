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
    public class PessoaControle
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

                Console.WriteLine("Informe a data de Nasc:");
                p.DataNasc = DateTime.Parse(Console.ReadLine());

                //Instânciando a entidade PessoaRepositorio
                var rep = new PessoaRepositorio();
                rep.Cadastrar(p);

                Console.WriteLine("\n Pessoa cadastrada com sucesso !");
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

                string resultado = rep.BuscarPessoaPoId(id).ToString();

                if (resultado != null)
                {
                    Console.WriteLine("\n Informações: "+resultado);
                    Console.Write("\n Deseja excluir ?: s/n " );
                    char opcao = char.Parse(Console.ReadLine());

                    if (opcao == 's')
                    {
                        rep.DeletarPessoa(id);
                        Console.WriteLine("\n Pessoa deletada com sucesso !!");
                    }
                    else
                    {
                        DeletarPessoa();
                    }
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

            Console.WriteLine("Informe o id da pessoa que você deseja alterar os dados: ");
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
                    Console.WriteLine("\n Informe a data de nascimento: ");
                    p.DataNasc = DateTime.Parse(Console.ReadLine());

                    rep.Alterar(p);

                    Console.WriteLine("\n Dados alterados com sucesso !");

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
                    Console.WriteLine("\n Resultados: " + rep.ConsultarPessoa().Count()+"\n");
                    Console.WriteLine("\n "+p.ToString()+"\n ");

                    Console.Write("Deseja voltar ao menu ? s/n: ");
                    char opcao = char.Parse(Console.ReadLine());

                    if (opcao == 's')
                    {
                        Console.Clear();
                        var inicio = new Inicio();
                        inicio.Menu();
                    }
                    else
                    {
                        Environment.Exit(1);
                    }
                    
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
