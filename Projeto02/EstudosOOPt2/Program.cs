﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudosOOPt2.Entidades; //Importando

namespace EstudosOOPt2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c = new Cliente(); // inicializando
            c.Endereco = new Endereco();

            c.IdCliente = 1;
            c.Nome = "Vinicius";
            c.Email = "bgvinicius@exemplo.com";
            c.Endereco.IdEndereco = 1;
            c.Endereco.Logradouro = "Rua Carla 12, Roncador";
            c.Endereco.Cidade = "Queimados";
            c.Endereco.Estado = "RJ";
            c.Endereco.Cep = "26381-754";

            Console.ReadKey();
        }
    }
}
