using CadastroUsuario.API.Models.Usuarios;

namespace CadastroUsuario.API.Configurations
{
    public interface IAuthenticationService
    {
        string GerarToken(UsuarioViewModelOutput usuarioViewModelOutput);
    }
}
