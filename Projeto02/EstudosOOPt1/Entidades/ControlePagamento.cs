namespace EstudosOOPt1.Entidades
{
    public class ControlePagamento
    {
        //Criando método para calcular pagamento
        public virtual double CalcularPgto(double valor)
        {
            return 0.0;
        }

        //Sobrecarregando o método CalcularPgto
        public virtual double CalcularPgto(double valor, int parcelas)
        {
            return 0.0;
        }


    }
}
