using System.ComponentModel.DataAnnotations;

namespace ProjetoAPI.Model
{
    public class RegistroViewModel
    {
        [Required(ErrorMessage = "O Login é Obrigatório")]
        public string Login { get; set; }

        [Required(ErrorMessage = "O E-mail é Obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A Senha é Obrigatório")]
        public string Senha { get; set; }
    }
}
