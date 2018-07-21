using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosOOPt1.Entidades
{
    public class Funcionario
    {
        //Encapsulamento Inplícito 
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }

        //Construtor
        public Funcionario()
        {

        }

        //Sobrecarregando o Construtor
        public Funcionario(int idFuncionario, string nome, decimal salario, DateTime dataAdmissao)
        {
            IdFuncionario = idFuncionario;
            Nome = nome;
            Salario = salario;
            DataAdmissao = dataAdmissao;
        }

        //Sobrescrevendo o método ToString da classe object
        public override string ToString()
        {
            return $"\n ID:{IdFuncionario}\n Nome:{Nome}\n Salário: R${Salario}\n DataAdmissão: {DataAdmissao}";
        }
    }
}
