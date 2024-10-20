using Applications.Interfaces;
using Domain.Entities;
using Infrastructure.Configuration;

namespace Applications.Services
{
    public class ClienteService : IClienteService
    {
        private readonly RepositoryConfiguration _configuration;

        public ClienteService(RepositoryConfiguration configuration)
        {
            _configuration = configuration;
        }

        public bool AlterarCliente(Cliente cliente)
        {
            try
            {
                return _configuration.clienteRepository.AlterarCliente(cliente);
            }
            catch
            {
                throw;
            }
        }

        public List<Cliente> ConsultarCliente(string nomeCliente)
        {
            try
            {
                return _configuration.clienteRepository.ConsultarCliente(nomeCliente);
            }
            catch
            {
                throw;
            }
        }

        public bool ExcluirCliente(int id)
        {
            try
            {
                return _configuration.clienteRepository.ExcluirCliente(id);
            }
            catch
            {
                throw;
            }
        }

        public bool IncluirCliente(Cliente cliente)
        {
            try
            {
                return _configuration.clienteRepository.IncluirCliente(cliente);
            }
            catch
            {
                throw;
            }
        }
    }
}