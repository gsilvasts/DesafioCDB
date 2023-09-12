using GS.DesafioCDB.API.Interfaces.Services;

namespace GS.DesafioCDB.API.Services
{
    public class CalculadoraIr : ICalculadoraIr
    {
        public decimal CalcularImposto(decimal valor, int meses)
        {
            decimal taxaImposto = PegarTaxaIR(meses);

            return valor * (taxaImposto / 100);
        }

        private decimal PegarTaxaIR(int meses)
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
