using System;

namespace EstudosOOPt1.Entidades
{
    public class FuncionarioLeitura
    {
        //Método para ler o id do funcionário
        public static int LerIdFuncionario()
        {
            Console.WriteLine("Informe o ID do funcionário: ");
            return int.Parse(Console.ReadLine());
        }

        //Método para ler o nome do funcionário
        public static string LerNome()
        {
            Console.WriteLine("Informe o Nome do funcionário: ");
            return Console.ReadLine();
        }

        //Método para ler o salário do funcionário
        public static decimal LerSalario()
        {
            Console.WriteLine("Informe o Salário do funcionário: ");
            return decimal.Parse(Console.ReadLine());
        }

        //Método para ler a data de admissão do funcionário
        public static DateTime LerDataAdmissao()
        {
            Console.WriteLine("Informe da Data de admissão: ");
            return DateTime.Parse(Console.ReadLine());
        }
    }
}
