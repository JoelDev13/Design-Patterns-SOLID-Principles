using DescuentosStrategyAPI.DTOs;
using DescuentosStrategyAPI.Strategies;
using Microsoft.AspNetCore.Mvc;

namespace DescuentosStrategyAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DescuentosController : ControllerBase
    {
        [HttpPost]
        public IActionResult AplicarDescuento([FromBody] SolicitudDescuento dto)
        {
            IDescuentoStrategy estrategia = dto.Tipo.ToLower() switch
            {
                "fijo" => new DescuentoFijo(dto.Valor),
                "porcentaje" => new DescuentoPorcentaje(dto.Valor),
                "ninguno" => new DescuentoNinguno(),
                _ => null
            };

            if (estrategia == null)
                return BadRequest("Tipo de descuento inválido. Use: 'fijo', 'porcentaje' o 'ninguno'.");

            var calculadora = new CalculadoraDescuentoService(estrategia);
            var montoFinal = calculadora.Calcular(dto.Monto);

            return Ok(new { MontoFinal = montoFinal });
        }
    }
}
