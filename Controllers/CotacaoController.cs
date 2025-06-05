using Microsoft.AspNetCore.Mvc;

namespace ControleInvestimentosItau.Controllers
{
    
        // CotacaoController.cs
        [ApiController]
        [Route("api/[controller]")]
        public class CotacaoController : ControllerBase
        {
            [HttpPost("nova")]
            public IActionResult ReceberCotacao([FromBody] object cotacaoDto)
            {
                // TODO: Receber nova cotação (via Kafka ou manual)
                return Ok();
            }

            [HttpGet("ativo/{ativoId}/historico")]
            public IActionResult GetHistoricoCotacoes(int ativoId)
            {
                // TODO: Buscar histórico de cotações
                return Ok();
            }
        }

    }

