using GS.DesafioCDB.API.Controllers;
using GS.DesafioCDB.API.Interfaces.Services;
using GS.DesafioCDB.API.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace GS.DesafioCDB.Tests
{
    public class CdbControllerTests
    {
        [Fact]
        public async Task CalcularCdb_RetornarOkResult()
        {
            //Arrange
            var investimentoInicial = 1000m;
            var meses = 6;
            var investimento = new Investimento(investimentoInicial, meses, 1100m, 1090m, 100m, 10m);

            var calculadoraCdbMock = new Mock<ICalculadoraCdbService>();

            calculadoraCdbMock.Setup(x => x.CalcularValorCDB(investimentoInicial, meses))
                .ReturnsAsync(investimento);

            var controller = new CdbController(calculadoraCdbMock.Object);

            //Act
            var resultado = await controller.CalcularCdb(investimentoInicial, meses) as OkObjectResult;
            var resultValue = resultado?.Value as Investimento;

            //Assert
            Assert.Equal(meses, resultValue?.MesesAplicacao);
            Assert.Equal(investimentoInicial, resultValue?.InvestimentoInicial);
        }

        [Fact]
        public async Task CalcularCdb_RetornarBadRequest()
        {
            //Arrange
            var investimentoInicial = 1000m;
            var meses = 0;
            var investimento = new Investimento(investimentoInicial, meses, 1100m, 1090m, 100m, 10m);
            var calculadoraCdbMock = new Mock<ICalculadoraCdbService>();

            calculadoraCdbMock.Setup(x => x.CalcularValorCDB(investimentoInicial, meses))
                .ReturnsAsync(investimento);

            var controller = new CdbController(calculadoraCdbMock.Object);

            //Act
            var resultado = await controller.CalcularCdb(investimentoInicial, meses);            

            //Assert
            Assert.IsType<BadRequestObjectResult>(resultado);
        }
    }
}
