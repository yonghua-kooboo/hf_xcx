using Mini.Data;
using Mini.Data.Entity;
using Mini.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mini.Dal
{
    public class DataProvider<T> : IDataProvider<T> where T: BaseModel
    {
        private readonly MiniDbContext dbContext;

        public DataProvider(MiniDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddAsync(T entity)
        {
            await dbContext.Set<T>().AddAsync(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task RemoveAsync(T entity)
        {
            dbContext.Set<T>().Remove(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            dbContext.Set<T>().Update(entity);
            await dbContext.SaveChangesAsync();
        }

        public IQueryable<T> GetAlls()
        {
            return dbContext.Set<T>().AsQueryable();
        }

        public T GetByID(Guid id)
        {
           return dbContext.Set<T>().Where(item => item.ID == id).FirstOrDefault();
        }
    }
}
