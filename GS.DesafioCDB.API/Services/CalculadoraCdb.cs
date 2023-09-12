using GS.DesafioCDB.API.Interfaces.Services;
using GS.DesafioCDB.API.Models;

namespace GS.DesafioCDB.API.Services
{
    public class CalculadoraCdb : ICalculadoraCdb
    {
        public Investimento CalcularValorCDB(decimal valor, int meses)
        {
            decimal cdi = 0.009M;
            decimal tb = 1.08M;
            decimal valorFinal = valor;

            for (int i = 0; i < meses; i++)
            {
                valorFinal = valorFinal * (1 + (cdi * tb));
            }

            decimal valorTaxavel = valorFinal - valor;

            var imposto = CalcularIR(valorTaxavel, meses);

            return new Investimento(valor, meses, valorFinal, valorFinal - imposto);
        }

        public decimal CalcularIR(decimal valor, int meses)
        {
            decimal taxaImposto = PegarTaxaIR(meses);

            return valor * (taxaImposto / 100);
        }

        public decimal PegarTaxaIR(int meses)
        {
            var taxa = meses switch
            {
                <= 6 => 22.5m,
                <= 12 => 20m,
                <= 24 => 17.5m,
                _ => 15m
            };

            return taxa;
        }
    }
}
