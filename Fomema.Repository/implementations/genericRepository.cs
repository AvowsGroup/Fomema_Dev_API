using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Fomema.DAL.DBContexts;
using Fomema.Repository.interfaces;
using Microsoft.EntityFrameworkCore;

namespace Fomema.Repository.implementations
{
	public abstract class genericRepository<T> : IgenericRepository<T> where T : class
	{
        protected readonly AppDBContext _context;

        protected genericRepository(AppDBContext context)
        {
            _context = context;
        }

        public async Task<T> Get(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
