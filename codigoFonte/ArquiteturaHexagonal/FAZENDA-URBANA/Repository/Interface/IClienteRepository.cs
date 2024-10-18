using Domain.Entities;

namespace Repository.Interface
{
    public interface IClienteRepository
    {
        bool IncluirCliente(Cliente cliente);
        List<Cliente> ConsultarCliente(string nomeCliente);
        bool AlterarCliente(Cliente cliente);
        bool ExcluirCliente(int id);
    }
}