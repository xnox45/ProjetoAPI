using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoAPI.Model;
using ProjetoAPI.Filter;
using Swashbuckle.AspNetCore.Annotations;

namespace ProjetoAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {                                          //Type define como vai ser o retorno podendo ser de um objeto a uma string
        [SwaggerResponse(statusCode: 200, description: "Sucesso ao autenticar", Type = typeof(LoginViewModel))]
        [SwaggerResponse(statusCode: 400, description: "Campos Obrigatórios", Type = typeof(ValidaCampoViewModel))]
        [SwaggerResponse(statusCode: 500, description: "Erro interno", Type = typeof(ErroGenericoViewModel))]
        [HttpPost]
        [Route("logar")]
        [ValidacaoModelState]//Assinatura de verificação costumizada
        public IActionResult Logar(LoginViewModel loginViewModel)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(new ValidaCampoViewModel(ModelState.SelectMany(sm => sm.Value.Errors)
            //        .Select(s => s.ErrorMessage)));
            //}

            //Retorna um status 200 de Sucess
            return Ok(loginViewModel);
        }

        [SwaggerResponse(statusCode: 400, description: "Campos Obrigatórios", Type = typeof(ValidaCampoViewModel))]
        [SwaggerResponse(statusCode: 500, description: "Erro interno", Type = typeof(ErroGenericoViewModel))]
        [HttpPost]
        [Route("registrar")]
        [ValidacaoModelState]
        public IActionResult Registrar(RegistroViewModel registroViewModel) 
        {
            //Retorna um status 201 de created
            return Created("", registroViewModel);
        }
    }
}
