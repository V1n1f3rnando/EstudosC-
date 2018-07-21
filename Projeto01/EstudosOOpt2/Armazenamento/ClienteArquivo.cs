using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudosOOpt2.Entidades;// Importando o namespace..
using System.IO; //Importando a classe do namespace System.IO para criar um arquivo de gravação

namespace EstudosOOpt2.Armazenamento
{
    public class ClienteArquivo
    {
        

        //Método para exportar os dados do cliente para txt.
        public void ExportarParaTxt(Cliente c)
        {
            //Passando como parâmetro o diretório do arquivo, e usando a expressão booleana true para acrescentar dados ao arquivo.
            StreamWriter sw =
                new StreamWriter("c:\\temp\\cliente.txt", true);

            sw.WriteLine("ID: " + c.IdCliente);
            sw.WriteLine("Nome: " + c.Nome);
            sw.WriteLine("Email: " + c.Email);
            sw.WriteLine("...");

            //Fechar arquivo...
            sw.Close();
        }

        //Método para exportar os dados do cliente para CSV.
        public void ExportarParaCsv(Cliente c)
        {
            StreamWriter sw = new StreamWriter("c:\\temp\\cliente.csv", true);

            //Gravando dados utilizando delimitador ';'
            sw.WriteLine("{0};{1};{2}", c.IdCliente, c.Nome, c.Email);

            // fechando arquivo
            sw.Close();

        }


    }
}
