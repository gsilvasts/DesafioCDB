using GS.DesafioCDB.API.Controllers;
using GS.DesafioCDB.API.Interfaces.Services;
using GS.DesafioCDB.API.Models;
using GS.DesafioCDB.API.Services;
using Moq;
using Xunit;

namespace GS.DesafioCDB.Test
{

    public class CalculadoraCdbTests
    {
        [Theory]
        [InlineData(1000, 6, 100)]
        [InlineData(1000, 12, 90)]
        [InlineData(1000, 24, 50)]
        [InlineData(1000, 36, 80)]
        public async Task CalcularCdb_CalculosCdbImpostosCorretos(decimal investimentoInicial, int meses, decimal imposto)
        {
            //Arrange           
            var investimento = new Investimento(investimentoInicial, meses, 1100m, 1090m, 100m, 10m);
            
            var calculadoraIrMock = new Mock<ICalculadoraIrService>();
            calculadoraIrMock.Setup(x=>x.CalcularImposto(investimento.RendimentoBruto, meses))
                .ReturnsAsync(imposto);

            var service = new CalculadoraCdbService(calculadoraIrMock.Object);

            //Act
            var result = await service.CalcularValorCDB(investimentoInicial, meses);

            //Assert
            Assert.Equal(imposto, investimento.Imposto);
            Assert.Equal(investimentoInicial, investimento.InvestimentoInicial);
            Assert.Equal(meses, investimento.MesesAplicacao);
            Assert.NotNull(investimento);
        }

    }
}
