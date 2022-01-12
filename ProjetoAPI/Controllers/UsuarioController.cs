using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoAPI.Model;
using Swashbuckle.AspNetCore.Annotations;

namespace ProjetoAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {                                          //Type defini como vai ser o retorno podendo ser de um objeto a uma string
        [SwaggerResponse(statusCode: 200, description: "Sucesso ao autenticar", Type = typeof(LoginViewModel))]
        [SwaggerResponse(statusCode: 400, description: "Campos Obrigatórios", Type = typeof(ValidaCampoViewModel))]
        [SwaggerResponse(statusCode: 500, description: "Erro interno", Type = typeof(ErroGenericoViewModel))]
        [HttpPost]
        [Route("logar")]
        public IActionResult Logar(LoginViewModel loginViewModel)
        {
            //Retorna um status 200 de Sucess
            return Ok(loginViewModel);
        }

        [HttpPost]
        [Route("registrar")]
        public IActionResult Registrar(RegistroViewModel registroViewModel) 
        {
            //Retorna um status 201 de created
            return Created("", registroViewModel);
        }
    }
}
