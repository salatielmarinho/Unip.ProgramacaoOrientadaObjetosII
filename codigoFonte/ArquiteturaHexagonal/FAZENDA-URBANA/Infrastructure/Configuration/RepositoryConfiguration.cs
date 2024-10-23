using Infrastructure.Interfaces;

namespace Infrastructure.Configuration
{
    public class RepositoryConfiguration
    {
        public IDatabaseInitializer dDatabaseInitializer { get; set; }
        public IDatabaseInitializerRepository dDatabaseInitializerRepository { get; set; }
        public IClienteRepository clienteRepository { get; set; }
        public IUsuarioRepository usuarioRepository { get; set; }
        public IPerfilRepository perfilRepository { get; set; }
    }

    public class Repository
    {
        private readonly IDatabaseInitializer _dDatabaseInitializer;
        private readonly IDatabaseInitializerRepository _dDatabaseInitializerRepository;
        private readonly IClienteRepository _clienteRepository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IPerfilRepository _perfilRepository;

        public Repository(RepositoryConfiguration configuration)
        {
            _dDatabaseInitializer = configuration.dDatabaseInitializer;
            _dDatabaseInitializerRepository = configuration.dDatabaseInitializerRepository;
            _clienteRepository = configuration.clienteRepository;
            _usuarioRepository = configuration.usuarioRepository;
            _perfilRepository = configuration.perfilRepository;
        }
    }
}