using System.Linq.Expressions;

namespace MyVaccine.WebApi.Services.Contracts
{
    public interface IBaseRepository<T>
    {
        Task Add(T entity);
        Task AddRange(List<T> entity);
        Task Update(T entity);
        Task UpdateRange(List<T> entity);
        Task Delete(T entity);
        Task DeleteRange(List<T> entity);
        IQueryable<T> GetAll();
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        Task Patch(T entity);
        Task PatchRange(List<T> entities);
        IQueryable<T> FindByAsNotTraking(Expression<Func<T, bool>> predicate);

    }
}
