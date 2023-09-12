namespace GS.DesafioCDB.API.Extensions
{
    public static class DecimalExtensions
    {
        public static decimal DuasCasasDecimais(this decimal @decimal)
        {
            return Math.Round(@decimal, 2);
        }
    }
}
