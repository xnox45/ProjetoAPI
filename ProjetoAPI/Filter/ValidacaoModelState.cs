using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ProjetoAPI.Model;

namespace ProjetoAPI.Filter
{
    //Faz com que conseguimos verificar todos os erros apenas com uma assinatura no metodo
    public class ValidacaoModelState : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var validarCampoModel = new ValidaCampoViewModel(context.ModelState.SelectMany(
                    sm => sm.Value.Errors)
                    .Select(s => s.ErrorMessage));
                context.Result = new BadRequestObjectResult(validarCampoModel);
            }
        }
    }
}
