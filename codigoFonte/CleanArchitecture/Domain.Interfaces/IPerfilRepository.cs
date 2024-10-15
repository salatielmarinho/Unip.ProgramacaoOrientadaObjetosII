using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IPerfilRepository
    {
        bool AlterarPerfil(Perfil perfil);
        List<Perfil> ConsultarPerfil();
        bool ExcluirPerfil(int perfilId);
        bool InserirPerfil(Perfil perfil);
    }
}