using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosOO.Entidades
{
    public class ProdutoImpressao
    {
        public void ImprimirDados(Produto p)
        {
            //Imprimindo 

            Console.WriteLine("\n -- Dados do Produto --");
            Console.WriteLine("\n ID:" + p.IdProduto);
            Console.WriteLine("\n Produto: " + p.Nome);
            Console.WriteLine("\n Preço: " + p.Preco);
            Console.WriteLine("\n Quantidade: " + p.Quantidade);

        }
    }
}
