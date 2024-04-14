using Microsoft.EntityFrameworkCore;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Persistence.Context;
using System.Linq.Expressions;

namespace MultiShop.Order.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly OrderContext _orderContext;

        public Repository(OrderContext orderContext)
        {
            _orderContext = orderContext;
        }

        public async Task CreateAsync(T entity)
        {
            _orderContext.Set<T>().Add(entity);
            await _orderContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
           _orderContext.Set<T>().Remove(entity);
            await _orderContext.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _orderContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter)
        {
            return await _orderContext.Set<T>().SingleOrDefaultAsync(filter);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _orderContext.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            _orderContext.Set<T>().Update(entity);
            await _orderContext.SaveChangesAsync();
        }
    }
}
