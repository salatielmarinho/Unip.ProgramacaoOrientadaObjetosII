using System.Linq.Expressions;

namespace Domain.Entities.Abstractions
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity? Obter(Expression<Func<TEntity, bool>> filtro);

        List<TEntity> ObterTodos();

        void Adicionar(TEntity entity);

        void Adicionar(IEnumerable<TEntity> entities);

        void Alterar(TEntity entity);

        void Excluir(TEntity entity);
    }
}