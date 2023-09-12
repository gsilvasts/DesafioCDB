namespace GS.DesafioCDB.API.Models
{
    public class Investimento
    {
        public Investimento(decimal investimentoInicial, int mesesAplicacao, decimal valorBruto, decimal valorLiquido)
        {
            InvestimentoInicial = investimentoInicial;
            MesesAplicacao = mesesAplicacao;
            ValorBruto = valorBruto;
            ValorLiquido = valorLiquido;
        }

        public decimal InvestimentoInicial { get; private set; }
        public int MesesAplicacao { get; private set; }
        public decimal ValorBruto { get; private set; }
        public decimal ValorLiquido { get; private set; }
    }
}
