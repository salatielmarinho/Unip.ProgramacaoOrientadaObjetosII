using Domain.Entities;

namespace Repository.Interface
{
    public interface IUsuarioRepository
    {
        bool IncluirUsuario(Usuario usuario);
        List<Usuario> ConsultarUsuario(string nomeCliente);
        bool AlterarUsuario(Usuario usuario);
        bool ExcluirUsuario(int id);
    }
}