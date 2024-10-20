using Domain.Entities;

namespace Applications.Interfaces
{
    public interface IClienteService
    {
        bool IncluirCliente(Cliente cliente);
        List<Cliente> ConsultarCliente(string nomeCliente);
        bool AlterarCliente(Cliente cliente);
        bool ExcluirCliente(int id);
    }
}