using Domain.Interface;

namespace Infrastructure.Configuration
{
    public class RepositoryConfiguration
    {
        public IClienteRepository clienteRepository { get; set; }
        public IUsuarioRepository usuarioRepository { get; set; }
    }

    public class Repository
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IUsuarioRepository _usuarioRepository;

        public Repository(RepositoryConfiguration configuration)
        {
            _clienteRepository = configuration.clienteRepository;
            _usuarioRepository = configuration.usuarioRepository;
        }
    }
}