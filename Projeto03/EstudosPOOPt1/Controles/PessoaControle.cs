using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudosPOOPt1.Entidades;
using EstudosPOOPt1.Repositorios;

namespace EstudosPOOPt1.Controles
{
    public class PessoaControle
    {
       public void CadastrarPessoa()
        {
            Console.WriteLine("\n - CADASTRO DE PESSOA \n ");

            try
            {

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

        public void ConsultarPessoas()
        {
            Console.WriteLine("\n - PESSOAS CADASTRADAS - \n");

            try
            {
                var rep = new PessoaRepositorio();

                foreach (var p in rep.ConsultarPessoa())
                {
                    Console.WriteLine(p.ToString());
                }

                Console.WriteLine(" Busca realizada com sucesso !");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }   
         
        }
        


    }
}
