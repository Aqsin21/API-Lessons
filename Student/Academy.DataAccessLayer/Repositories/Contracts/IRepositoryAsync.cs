using Academy.DataAccessLayer.DataContext.Entities;
using System.Linq.Expressions;


namespace Academy.DataAccessLayer.Repositories.Contracts
{
    public  interface IRepositoryAsync<T> where T :BaseEntity
    {
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetAllIncludingAsync(params Expression<Func<T, object>>[] includes);
        Task<T> GetByIdAsync(int  id);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(int id);
        



    }
}
