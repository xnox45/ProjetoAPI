using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoAPI.Model;

namespace ProjetoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        public IActionResult Logar(LoginViewModel loginViewModel)
        {
            //Retorna um status 201 de created
            return Created("", loginViewModel);
        }
    }
}
