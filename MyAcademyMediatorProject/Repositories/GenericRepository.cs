
using Microsoft.EntityFrameworkCore;
using MyAcademyMediatorProject.Context;

namespace MyAcademyMediatorProject.Repositories
{
    public class GenericRepository<TEntity>(AppDbContext context) : IRepository<TEntity> where TEntity : class
    {
        public async Task CreateAsync(TEntity entity)
        {
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid Id)
        {
            var entity = await GetByIdAsync(Id);
            context.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await context.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(Guid Id)
        {
            return await context.Set<TEntity>().FindAsync(Id);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            context.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
