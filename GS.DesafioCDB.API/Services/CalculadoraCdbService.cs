using GS.DesafioCDB.API.Extensions;
using GS.DesafioCDB.API.Interfaces.Services;
using GS.DesafioCDB.API.Models;

namespace GS.DesafioCDB.API.Services
{
    public class CalculadoraCdbService : ICalculadoraCdbService
    {
        private readonly ICalculadoraIrService _calculadoraIr;

        public CalculadoraCdbService(ICalculadoraIrService calculadoraIr)
        {
            _calculadoraIr = calculadoraIr;
        }

        public async Task<Investimento> CalcularValorCDB(decimal investimentoInicial, int meses)
        {
            decimal cdi = 0.009m;
            decimal tb = 1.08m;
            decimal valorCdb = investimentoInicial;

            for (int i = 0; i < meses; i++)
            {
                valorCdb = valorCdb * (1 + (cdi * tb));
            }

            decimal rendimentoBruto = valorCdb - investimentoInicial;

            decimal imposto = await _calculadoraIr.CalcularImposto(rendimentoBruto, meses);

            return new Investimento(investimentoInicial, meses, valorCdb.DuasCasasDecimais(), (valorCdb - imposto).DuasCasasDecimais(), rendimentoBruto, imposto);
        }
                
    }
}
