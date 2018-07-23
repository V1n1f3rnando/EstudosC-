﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudosPOOPt1.Entidades;
using System.Data.SqlClient;


namespace EstudosPOOPt1.Repositorios
{
    public class PessoaRepositorio : Conexao
    {
        public void Cadastrar(Pessoa p)
        {
            AbrirConexao();

            //Escrevendo o comando em sql
            string query = "insert into Pessoa (nome, dataNascimento) values (@nome, @dataNascimento) ";

            //executando o comando 
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nome",p.Nome);
            cmd.Parameters.AddWithValue("@dataNascimento", p.DataNasc);
            cmd.ExecuteNonQuery();

            FecharConexao(); //desconectando

        }

        public List<Pessoa> ConsultarPessoa()
        {
            AbrirConexao();

            string query = "select * from Pessoa";

            cmd = new SqlCommand(query, con);

            dr = cmd.ExecuteReader();

            //Declarando uma lista de pessoas
            List<Pessoa> lista = new List<Pessoa>();

            while (dr.Read())
            {
                var p = new Pessoa();

                p.IdPessoa = Convert.ToInt32(dr["IdPessoa"]);
                p.Nome = Convert.ToString(dr["nome"]);
                p.DataNasc = Convert.ToDateTime(dr["dataNascimento"]);

                lista.Add(p); //armazenando na lista
            }

            FecharConexao();

            return lista; // retonando a lista 
        }
    }
}
