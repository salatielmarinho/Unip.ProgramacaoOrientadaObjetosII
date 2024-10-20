using Domain.Entities;

namespace Domain.Interface
{
    public interface IUsuarioRepository
    {
        bool IncluirUsuario(Usuario usuario);
        List<Usuario> ConsultarUsuario(string nomeCliente);
        bool AlterarUsuario(Usuario usuario);
        bool ExcluirUsuario(int id);
    }
}