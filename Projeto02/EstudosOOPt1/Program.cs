using System;
using EstudosOOPt1.Entidades; // Importando as entidades 
using EstudosOOPt1.Leitura;


namespace EstudosOOPt1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Instânciando a classe Funcionario
             var f = new Funcionario();

            //Utilizando os métodos abstratos da classe FuncionarioLeitura
            f.IdFuncionario = FuncionarioLeitura.LerIdFuncionario();
            f.Nome = FuncionarioLeitura.LerNome();
            f.Salario = FuncionarioLeitura.LerSalario();
            f.DataAdmissao = FuncionarioLeitura.LerDataAdmissao();

            //Imprimindo
            Console.Write("\n ID: " + f.IdFuncionario);
            Console.Write("\n Nome:" + f.Nome);
            Console.Write("\n Salário: " + f.Salario);
            Console.Write("\n DataAdmissão: " + f.DataAdmissao);

            Console.ReadKey(); // pausando o cursor 
        }
    }
}
