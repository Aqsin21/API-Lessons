using Academy.DataAccessLayer.DataContext.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.DataAccessLayer.Repositories.Contracts
{
    public  interface IRepositoryAsync<T> where T :BaseEntity
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int  id);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(int id);
        



    }
}
