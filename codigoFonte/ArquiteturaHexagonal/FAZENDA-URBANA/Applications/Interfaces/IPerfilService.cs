using Domain.Entities;

namespace Applications.Interfaces
{
    public interface IPerfilService
    {
        bool IncluirPerfil(Perfil perfil);
        List<Perfil> ConsultarPerfil(string nomePerfil);
        List<Perfil> ConsultarTodosPerfis();
        bool AlterarPerfil(Perfil perfil);
        bool ExcluirPerfil(int id);
    }
}