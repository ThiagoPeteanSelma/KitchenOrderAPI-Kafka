using Microsoft.AspNetCore.Mvc;
using KitchenOrderAPI.Models;   // DTOs de login
using KitchenOrderAPI.Services; // Serviço de autenticação

namespace KitchenOrderAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        // POST /api/auth/token
        [HttpPost("token")]
        public IActionResult GenerateToken([FromBody] LoginDto login)
        {
            // TODO: Lógica para gerar JWT
            return Ok(new { token = "jwt-token-aqui" });
        }
    }
}
