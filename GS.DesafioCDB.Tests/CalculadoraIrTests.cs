using GS.DesafioCDB.API.Services;

namespace GS.DesafioCDB.Tests
{
    public class CalculadoraIrTests
    {
        [Theory]
        [InlineData(1000, 6)]
        [InlineData(1000, 12)]
        [InlineData(1000, 24)]
        [InlineData(1000, 36)]
        public async Task CalcularCdb_CalculosCdbImpostosCorretos(decimal rendimento, int meses)
        {
            //Arrange            
            var service = new CalculadoraIrService();

            //Act
            var result = await service.CalcularImposto(rendimento, meses);

            //Assert
            Assert.True(result > 0);
        }

    }
}
