using System.Collections.Generic;
using System.Threading.Tasks;

namespace NeonHackathon.Domain.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<ICollection<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T updated);
        Task DeleteAsync(T t);
    }
}
