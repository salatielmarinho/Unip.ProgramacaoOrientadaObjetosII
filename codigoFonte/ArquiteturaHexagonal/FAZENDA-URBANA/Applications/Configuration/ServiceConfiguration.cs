using Applications.Interfaces;

namespace Applications.Configuration
{
    public class ServiceConfiguration
    {
        public IClienteService clienteService { get; set; }
        public IUsuarioService usuarioService { get; set; }
    }

    public class Service
    {
        private readonly IClienteService _clienteService;
        private readonly IUsuarioService _usuarioService;

        public Service(ServiceConfiguration configuration)
        {
            _clienteService = configuration.clienteService;
            _usuarioService = configuration.usuarioService;
        }
    }
}