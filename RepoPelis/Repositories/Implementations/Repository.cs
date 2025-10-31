using Microsoft.EntityFrameworkCore;
using RepoPelis.DAL;
using RepoPelis.Repositories.Interfaces;
using System.Collections.Generic;

namespace RepoPelis.Repositories.Implementations
{
    public class Repository <T>: IRepository<T> where T : class
    {
        protected readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(AppDbContext context){
            _context = context;
            _dbSet = context.Set<T>();
            }
        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
            throw new NotImplementedException();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
            throw new NotImplementedException();
        }

        public void  Remove(T entity)
        {
            _dbSet.Remove(entity);
            throw new NotImplementedException();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
            throw new NotImplementedException();
        }
    }
}
