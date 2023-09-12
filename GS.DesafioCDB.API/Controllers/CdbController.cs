using GS.DesafioCDB.API.Interfaces.Services;
using GS.DesafioCDB.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GS.DesafioCDB.API.Controllers
{
    [Route("api/cdb")]
    [ApiController]
    public class CdbController : ControllerBase
    {
        private readonly ICalculadoraCdb _calculadora;

        public CdbController(ICalculadoraCdb calculadora)
        {
            _calculadora = calculadora;
        }

        [HttpGet("{investimentoInicial}/{meses}")]
        public IActionResult CalcularCdb(decimal investimentoInicial, int meses)
        {
            if(investimentoInicial<=0 || meses <= 0)
            {
                return BadRequest("Informe um valor válido para o investimento e para a quantidade de meses da aplicação.");
            }

            var retorno = _calculadora.CalcularValorCDB(investimentoInicial, meses);

            return Ok(retorno);
        }

    }
}
