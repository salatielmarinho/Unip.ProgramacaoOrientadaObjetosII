using Domain.Entities;

namespace Repository.Interface
{
    public interface IClienteRepository
    {
        bool IncluirCliente(ClienteEntitie clienteEntitie);
        List<ClienteEntitie> ConsultarCliente(string nomeCliente);
        bool AlterarCliente(ClienteEntitie clienteEntitie);
        bool ExcluirCliente(int id);
    }
}