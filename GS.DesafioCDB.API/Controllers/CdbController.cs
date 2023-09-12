﻿using GS.DesafioCDB.API.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace GS.DesafioCDB.API.Controllers
{
    [Route("api/cdb")]
    [ApiController]
    public class CdbController : ControllerBase
    {
        private readonly ICalculadoraCdbService _calculadora;

        public CdbController(ICalculadoraCdbService calculadora)
        {
            _calculadora = calculadora;
        }

        [HttpGet("{investimentoInicial}/{meses}")]
        public async Task<IActionResult> CalcularCdb(decimal investimentoInicial, int meses)
        {
            if (investimentoInicial <= 0 || meses <= 0)
            {
                return BadRequest("Informe um valor válido para o investimento e para a quantidade de meses da aplicação.");
            }

            var retorno = await _calculadora.CalcularValorCDB(investimentoInicial, meses);

            return Ok(retorno);
        }

    }
}
