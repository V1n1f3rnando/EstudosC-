﻿using System;
using EstudosOOPt1.Entidades; // Importando as entidades 


namespace EstudosOOPt1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instânciando a classe Funcionario
            // var f = new Funcionario();

            var f = new Funcionario();

            //Imprimindo
            Console.Write("\n ID: " + f.IdFuncionario);
            Console.Write("\n Nome:" + f.Nome);
            Console.Write("\n Salário: " + f.Salario);
            Console.Write("\n DataAdmissão: " + f.DataAdmissao);

            Console.ReadKey(); // pausando o cursor 
        }
    }
}
