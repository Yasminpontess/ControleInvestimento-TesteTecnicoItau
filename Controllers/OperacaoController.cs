using Microsoft.AspNetCore.Mvc;

namespace ControleInvestimentosItau.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OperacaoController : ControllerBase
    {
        [HttpPost("nova")]
        public IActionResult RegistrarOperacao([FromBody] object operacaoDto)
        {
            // TODO: Registrar nova compra/venda
            return Ok();
        }

        [HttpGet("usuario/{usuarioId}/ativo/{ativoId}/ultimos-30-dias")]
        public IActionResult GetOperacoesUltimos30Dias(int usuarioId, int ativoId)
        {
            // TODO: Consultar operações dos últimos 30 dias
            return Ok();
        }
    }
}

