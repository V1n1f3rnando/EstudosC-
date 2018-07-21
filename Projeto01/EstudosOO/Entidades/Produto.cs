using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosOO.Entidades
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        //Construtor 
        public Produto()
        {

        }

        //Sobrecarregando o construtor 
        public Produto(int idProduto, string nome, decimal preco)
        {
            IdProduto = idProduto;
            Nome = nome;
            Preco = preco;
        }

        //Sobrescrevendo o Método ToString da classe object 
        public override string ToString()
        {
            return $"ID{IdProduto}\n Produto:{Nome}\n Preço: R${Preco}";
        }
    }
}
