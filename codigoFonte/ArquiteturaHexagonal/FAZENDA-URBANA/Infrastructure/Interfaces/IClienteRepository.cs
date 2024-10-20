using Domain.Entities;

namespace Infrastructure.Interface
{
    public interface IClienteRepository
    {
        bool IncluirCliente(Cliente cliente);
        List<Cliente> ConsultarCliente(string nomeCliente);
        bool AlterarCliente(Cliente cliente);
        bool ExcluirCliente(int id);
    }
}