using GS.DesafioCDB.API.Models;

namespace GS.DesafioCDB.API.Interfaces.Services
{
    public interface ICalculadoraCdbService
    {
        /// <summary>
        /// Calcula o valor liquido do CDB
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="meses"></param>
        /// <returns></returns>
        Task<Investimento> CalcularValorCDB(decimal investimentoInicial, int meses);
    }
}
