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
        //Passando como parâmetro o diretório do arquivo, e usando a expressão booleana true para acrescentar dados ao arquivo.
        StreamWriter sw = new StreamWriter("c:\\temp\\cliente.txt", true); 


    }
}
