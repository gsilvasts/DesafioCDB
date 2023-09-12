using GS.DesafioCDB.API.Models;

namespace GS.DesafioCDB.API.Interfaces.Services
{
    public interface ICalculadoraCdb
    {
        /// <summary>
        /// Calcula o valor liquido do CDB
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="meses"></param>
        /// <returns></returns>
        Investimento CalcularValorCDB(decimal valor, int meses);
    }
}
