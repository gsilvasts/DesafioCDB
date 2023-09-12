namespace GS.DesafioCDB.API.Models
{
    public class Investimento
    {
        public Investimento(decimal investimentoInicial, int mesesAplicacao, decimal valorBruto, decimal valorLiquido, decimal rendimentoBruto, decimal imposto)
        {
            InvestimentoInicial = investimentoInicial;
            MesesAplicacao = mesesAplicacao;
            ValorBruto = valorBruto;
            ValorLiquido = valorLiquido;
            RendimentoBruto = rendimentoBruto;
            Imposto = imposto;
        }

        public decimal InvestimentoInicial { get; private set; }
        public int MesesAplicacao { get; private set; }
        public decimal ValorBruto { get; private set; }
        public decimal ValorLiquido { get; private set; }
        public decimal RendimentoBruto { get; private set; }
        public decimal Imposto { get; private set; }        
    }
}
