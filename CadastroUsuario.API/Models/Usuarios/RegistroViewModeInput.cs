using System.ComponentModel.DataAnnotations;

namespace CadastroUsuario.API.Models.Usuarios
{
    public class RegistroViewModeInput
    {
        [Required(ErrorMessage = "O login é obrigatório")]
        public string Login { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória")]
        public string Senha { get; set; }

    }
}
