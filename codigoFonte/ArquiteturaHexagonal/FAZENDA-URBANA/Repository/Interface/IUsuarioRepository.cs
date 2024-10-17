using Domain.Entities;

namespace Repository.Interface
{
    public interface IUsuarioRepository
    {
        bool IncluirUsuario(UsuarioEntitie usuarioEntitie);
        List<UsuarioEntitie> ConsultarUsuario(string nomeCliente);
        bool AlterarUsuario(UsuarioEntitie usuarioEntitie);
        bool ExcluirUsuario(int id);
    }
}