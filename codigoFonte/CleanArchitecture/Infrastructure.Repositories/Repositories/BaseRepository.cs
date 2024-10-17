using Domain.Entities.Abstractions;
using Infrastructure.Data.Context;
using System.Linq.Expressions;

namespace Infrastructure.Repositories.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly DataContext dataContext;

        public BaseRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public TEntity? Obter(Expression<Func<TEntity, bool>> filtro)
        {
            return dataContext.Set<TEntity>().SingleOrDefault(filtro);
        }

        public List<TEntity> ObterTodos()
        {
            List<TEntity> ret = dataContext.Set<TEntity>().ToList<TEntity>();

            if (ret == null) ret = new List<TEntity>();

            return ret;
        }

        public void Adicionar(TEntity entity)
        {
            dataContext.Set<TEntity>().Add(entity);
        }

        public void Adicionar(IEnumerable<TEntity> entities)
        {
            dataContext.Set<TEntity>().AddRange(entities);
        }

        public void Alterar(TEntity entity)
        {
            dataContext.Set<TEntity>().Update(entity);
        }

        public void Excluir(TEntity entity)
        {
            dataContext.Remove(entity);
        }

        public void Dispose()
        {
            try
            {
                if (dataContext != null) dataContext.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}