using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudosOOpt2.Entidades; //Importando o namespace Entidades
using EstudosOOpt2.Armazenamento; //Importando o namespace que contém os métodos de gravação

namespace EstudosOOpt2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n --- CONTROLE DE CLIENTES ---");
            
            // Instânciando a entidade Cliente
            var c = new Cliente();

            Console.Write("\n Informe o ID: ");
            c.IdCliente = int.Parse(Console.ReadLine());

            Console.Write("\n Informe o nome: ");
            c.Nome = Console.ReadLine();

            Console.Write("\n Informe o email: ");
            c.Email = Console.ReadLine();

            //Tratamento de exceção 
            try
            {
                //Instânciando a entidade ClienteArquivo e fazendo o uso dos métodos de exportação
                var arquivo = new ClienteArquivo();

                arquivo.ExportarParaTxt(c);
                arquivo.ExportarParaCsv(c);

                Console.WriteLine("\n Dados gravados com sucesso !! ");
                
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falha ao gravar o arquivo !! erro:"+ex.ToString());
            }

            Console.ReadKey();
        }
    }
}
