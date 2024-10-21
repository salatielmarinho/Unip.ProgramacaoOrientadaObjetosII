using Applications.Interfaces;
using Domain.Entities;
using Infrastructure.Configuration;

namespace Applications.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly RepositoryConfiguration _configuration;

        public UsuarioService(RepositoryConfiguration configuration)
        {
            _configuration = configuration;
        }

        public bool AlterarUsuario(Usuario usuario)
        {
            try
            {
                return _configuration.usuarioRepository.AlterarUsuario(usuario);
            }
            catch
            {
                throw;
            }
        }

        public int ConsultarPerfilUsuario(Usuario usuario)
        {
            try
            {
                return _configuration.usuarioRepository.ConsultarPerfilUsuario(usuario);
            }
            catch
            {
                throw;
            }
        }

        public List<Usuario> ConsultarUsuario(string nomeCliente)
        {
            try
            {
                return _configuration.usuarioRepository.ConsultarUsuario(nomeCliente);
            }
            catch
            {
                throw;
            }
        }

        public bool ExcluirUsuario(int id)
        {
            try
            {
                return _configuration.usuarioRepository.ExcluirUsuario(id);
            }
            catch
            {
                throw;
            }
        }

        public bool IncluirUsuario(Usuario usuario)
        {
            try
            {
                return _configuration.usuarioRepository.IncluirUsuario(usuario);
            }
            catch
            {
                throw;
            }
        }
    }
}