using Microsoft.AspNetCore.Mvc;

namespace ControleInvestimentosItau.Controllers
{
    // AtivoController.cs
    [ApiController] //API controller attribute to indicate this class is an API controller
    [Route("api/[controller]")] // Route attribute to define the base route for this controller 
    public class AtivoController : ControllerBase // Defines the controller class, which must inherit from ControllerBase to be able to use API features such as Ok(), BadRequest()
    {
        [HttpGet("{codigo}/cotacao-atual")] // Define a GET endpoint
        public IActionResult GetCotacaoAtual(string codigo) //method that will be executed when the above route is called.
        {
            // TODO: Buscar última cotação do ativo
            return Ok();
        }
    }
}
