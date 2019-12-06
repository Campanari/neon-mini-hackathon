using Microsoft.EntityFrameworkCore;
using NeonHackathon.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NeonHackathon.Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly NeonHackathonContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public GenericRepository(NeonHackathonContext context)
        {
            _context = context;
            _unitOfWork = new UnitOfWork(context);
        }

        public async Task<ICollection<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            //await _unitOfWork.Commit();
            return await Task.FromResult(entity);
        }

        public async Task<T> UpdateAsync(T updated)
        {
            if (updated == null)
            {
                return null;
            }

            _context.Set<T>().Attach(updated);
            _context.Entry(updated).State = EntityState.Modified;
            //await _unitOfWork.Commit();

            return await Task.FromResult(updated);
        }

        public async Task DeleteAsync(T t)
        {
            await Task.FromResult(_context.Set<T>().Remove(t));
            //return await _unitOfWork.Commit();
        }
    }

}
