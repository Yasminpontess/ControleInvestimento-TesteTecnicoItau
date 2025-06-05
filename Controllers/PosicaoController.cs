
using Microsoft.AspNetCore.Mvc;

namespace ControleInvestimentosItau.Controllers
{
    // PosicaoController.cs
    [ApiController]
    [Route("api/[controller]")]
    public class PosicaoController : ControllerBase
    {
        [HttpGet("usuario/{id}/ativos")]
        public IActionResult GetPosicaoPorUsuario(int id)
        {
            // TODO: Retornar posição por ativo
            return Ok();
        }

        [HttpGet("top10/posicoes")]
        public IActionResult GetTop10Posicoes()
        {
            // TODO: Retornar top 10 clientes por posição
            return Ok();
        }

        [HttpGet("top10/corretagem")]
        public IActionResult GetTop10Corretagem()
        {
            // TODO: Retornar top 10 clientes por corretagem
            return Ok();
        }
    }
}

    