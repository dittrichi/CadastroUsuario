using CadastroUsuario.API.Business.Entities;

namespace CadastroUsuario.API.Business.Repositories
{
    public interface ICursoRepository
    {
        void Adicionar(CadastroUsuario.API.Business.Entities.Curso curso);
        void Commit();
        System.Collections.Generic.IList<CadastroUsuario.API.Business.Entities.Curso> ObterPorUsuario(int codigoUsuario);
    }
}
