using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        List<Usuario> ConsultarUsuario();
        bool AlterarUsuario(Usuario usuario);
        bool ExcluirUsuario(int usuarioId);
        bool InserirUsuario(Usuario usuario);
    }
}