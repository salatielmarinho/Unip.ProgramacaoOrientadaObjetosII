using Applications.Interfaces;
using Domain.Entities;
using Infrastructure.Configuration;

namespace Applications.Services
{
    public class PerfilService : IPerfilService
    {
        private readonly RepositoryConfiguration _configuration;

        public PerfilService(RepositoryConfiguration configuration)
        {
            _configuration = configuration;
        }

        public bool AlterarPerfil(Perfil Perfil)
        {
            try
            {
                return _configuration.perfilRepository.AlterarPerfil(Perfil);
            }
            catch
            {
                throw;
            }
        }

        public List<Perfil> ConsultarPerfil(string nomePerfil)
        {
            try
            {
                return _configuration.perfilRepository.ConsultarPerfil(nomePerfil);
            }
            catch
            {
                throw;
            }
        }

        public List<Perfil> ConsultarTodosPerfis()
        {
            try
            {
                return _configuration.perfilRepository.ConsultarTodosPerfis();
            }
            catch
            {
                throw;
            }
        }

        public bool ExcluirPerfil(int id)
        {
            try
            {
                return _configuration.perfilRepository.ExcluirPerfil(id);
            }
            catch
            {
                throw;
            }
        }

        public bool IncluirPerfil(Perfil Perfil)
        {
            try
            {
                return _configuration.perfilRepository.IncluirPerfil(Perfil);
            }
            catch
            {
                throw;
            }
        }
    }
}