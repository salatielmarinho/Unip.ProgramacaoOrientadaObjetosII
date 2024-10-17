using Domain.Entities.Entities;

namespace Domain.Entities.Abstractions
{
    public interface IAlunoRepositoryEF : IBaseRepository<Aluno>
    {
        IEnumerable<Aluno> ObterPorNome(string nome);

        //Contato? ContatoExistenteComMesmoTelefone(string telefone);

        //Contato? ContatoExistenteComMesmoEmail(string email);
    }
}