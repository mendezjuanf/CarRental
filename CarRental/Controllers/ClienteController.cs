using CarRental.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class ClienteController : Controller
    {
        private static List<Cliente> clientes = new List<Cliente>();

        [HttpGet("verClientes")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<Local>> GetClientes()
        {
            return Ok(clientes);
        }

        [HttpPost("addcliente")]
        public IActionResult AgregarLocal([FromBody] Cliente cliente)
        {
            clientes.Add(cliente);
            return Ok(cliente);
        }
    }
}
