using Domain.Entities.Abstractions;
using Domain.Entities.Entities;
using Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Repositories
{
    public sealed class AlunoRepositoryEF : BaseRepository<Aluno>, IAlunoRepositoryEF
    {
        private readonly DataContext dataContext;

        public AlunoRepositoryEF(DataContext dataContext)
           : base(dataContext)
        {
            this.dataContext = dataContext;
        }

        public IEnumerable<Aluno> ObterPorNome(string nome)
        {
            var consulta = dataContext.Aluno.AsNoTracking();

            if (nome != null)
                consulta = consulta.Where(x => x.Nome == nome);

            return consulta;
        }
    }
}