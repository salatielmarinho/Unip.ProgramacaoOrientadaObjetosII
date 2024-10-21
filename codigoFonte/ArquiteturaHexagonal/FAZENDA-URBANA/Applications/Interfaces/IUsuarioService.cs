using Domain.Entities;

namespace Applications.Interfaces
{
    public interface IUsuarioService
    {
        bool IncluirUsuario(Usuario usuario);
        List<Usuario> ConsultarUsuario(string nomeCliente);
        bool AlterarUsuario(Usuario usuario);
        bool ExcluirUsuario(int id);
        int ConsultarPerfilUsuario(Usuario usuario);
    }
}