using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EstudosOOPt1.Entidades; // Importando as entidades 
using System.IO; //Importando o namespace que contém a classe de escrita e leitura de arquivos.

namespace EstudosOOPt1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instânciando a classe Funcionario
            // var f = new Funcionario();

            f.IdFuncionario =

            //Imprimindo
            Console.Write("\n ID: " + f.IdFuncionario);
            Console.Write("\n Nome:" + f.Nome);
            Console.Write("\n Salário: " + f.Salario);
            Console.Write("\n DataAdmissão: " + f.DataAdmissao);

            Console.ReadKey(); // pausando o cursor 
        }
    }
}
