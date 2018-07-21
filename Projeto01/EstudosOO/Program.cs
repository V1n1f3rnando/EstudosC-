using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudosOO.Entidades;

namespace EstudosOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Estudo01 ----- C# ");

            Console.Write("\n Informe seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("\n Seja bem vindo:"+nome+" !!");

            //Instânciando a classe Produto 
            var p = new Produto();

            Console.WriteLine("\n -- CADASTRO DE PRODUTOS --");

            Console.Write("\n Indorme o ID do produto: ");
            p.IdProduto = Convert.ToInt32(Console.ReadLine()); //Convertendo o tipo string para int

            Console.Write("\n Informe o nome do produto: ");
            p.Nome = Console.ReadLine();

            Console.Write("\n Informe o preço do produto: ");
            p.Preco = decimal.Parse(Console.ReadLine()); // tipo.parse outra forma de conversão, converte de string para outro tipo.

            Console.Write("\n Informe a quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            //Instânciando a classe produto impressão e chamando o método ImprimirDados
            var imprimir = new ProdutoImpressao();
            imprimir.ImprimirDados(p);

            Console.ReadKey();
        }
    }
}
