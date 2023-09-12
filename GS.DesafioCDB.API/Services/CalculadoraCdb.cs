using GS.DesafioCDB.API.Extensions;
using GS.DesafioCDB.API.Interfaces.Services;
using GS.DesafioCDB.API.Models;

namespace GS.DesafioCDB.API.Services
{
    public class CalculadoraCdb : ICalculadoraCdb
    {
        private readonly ICalculadoraIr _calculadoraIr;

        public CalculadoraCdb(ICalculadoraIr calculadoraIr)
        {
            _calculadoraIr = calculadoraIr;
        }

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

            var imposto = _calculadoraIr.CalcularImposto(valorTaxavel, meses);

            return new Investimento(valor, meses, valorFinal.DuasCasasDecimais(), (valorFinal - imposto).DuasCasasDecimais());
        }
                
    }
}
