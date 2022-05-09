namespace ExemploComposicao
{
    class Emprego
    {
        string descricao;
        double salarioAtual;

        public Emprego(string descricao, double salarioAtual)
        {
            this.descricao = descricao;
            this.salarioAtual = salarioAtual;
        }

        public string Descricao
        {
            get
            {
                return descricao;
            }
        }

        public double SalarioAtual
        {
            get
            {
                return salarioAtual;
            }
        }

        public void ReajustarSalario(double reajuste)
        {
            salarioAtual += reajuste;
        }
    }
}