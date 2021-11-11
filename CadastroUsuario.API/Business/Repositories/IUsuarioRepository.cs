using CadastroUsuario.API.Business.Entities;

namespace CadastroUsuario.API.Business.Repositories
{
    public interface IUsuarioRepository
    {
        void Adicionar(Usuario usuario);
        void Commit();
        Usuario ObterUsuario(string login);
    }
}
