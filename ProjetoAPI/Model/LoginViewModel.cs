using System.ComponentModel.DataAnnotations;

namespace ProjetoAPI.Model
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "O Login é Obrigatório")]
        public string Login { get; set; }

        [Required(ErrorMessage = "A Senha é Obrigatório")]
        public string Senha { get; set; }
    }
}
