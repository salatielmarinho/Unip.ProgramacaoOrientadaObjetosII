using Infrastructure.Interfaces;

namespace Infrastructure.Configuration
{
    public class RepositoryConfiguration
    {
        public IDatabaseInitializerRepository databaseInitializerRepository { get; set; }
        public IClienteRepository clienteRepository { get; set; }
        public IUsuarioRepository usuarioRepository { get; set; }
        public IPerfilRepository perfilRepository { get; set; }
    }

    public class Repository
    {
        private readonly IDatabaseInitializerRepository _databaseInitializerRepository;
        private readonly IClienteRepository _clienteRepository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IPerfilRepository _perfilRepository;

        public Repository(RepositoryConfiguration configuration)
        {
            _databaseInitializerRepository = configuration.databaseInitializerRepository;
            _clienteRepository = configuration.clienteRepository;
            _usuarioRepository = configuration.usuarioRepository;
            _perfilRepository = configuration.perfilRepository;
        }
    }
}