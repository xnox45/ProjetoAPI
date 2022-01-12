namespace ProjetoAPI.Model
{
    public class ValidaCampoViewModel
    {
        public IEnumerable<string> Erro {get; set;}

        public ValidaCampoViewModel(IEnumerable<string> erro)
        {
            Erro = erro;
        }
    }
}
