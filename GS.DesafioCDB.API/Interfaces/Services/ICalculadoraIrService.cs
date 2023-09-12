namespace GS.DesafioCDB.API.Interfaces.Services
{
    public interface ICalculadoraIrService
    {
        Task<decimal> CalcularImposto(decimal valor, int meses);
    }
}
