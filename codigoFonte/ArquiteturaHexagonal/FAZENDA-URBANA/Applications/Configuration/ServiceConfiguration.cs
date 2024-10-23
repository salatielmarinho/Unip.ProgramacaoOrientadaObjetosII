using Applications.Interfaces;

namespace Applications.Configuration
{
    public class ServiceConfiguration
    {
        public IDatabaseInitializerService databaseInitializerService { get; set; }
        public IClienteService clienteService { get; set; }
        public IUsuarioService usuarioService { get; set; }
        public IPerfilService perfilService { get; set; }
    }

    public class Service
    {
        public readonly IDatabaseInitializerService _databaseInitializerService;
        private readonly IClienteService _clienteService;
        private readonly IUsuarioService _usuarioService;
        private readonly IPerfilService _perfilService;

        public Service(ServiceConfiguration configuration)
        {
            _databaseInitializerService = configuration.databaseInitializerService;
            _clienteService = configuration.clienteService;
            _usuarioService = configuration.usuarioService;
            _perfilService = configuration.perfilService;
        }
    }
}