using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Salik_Inventory_Management_System.UI.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Salik_Inventory_Management_System.UI.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {

        private readonly SalikInventoryManagementDbContextFactory _dbContextfactory;
        private DbContext @object;

        public Repository()
        {
            _dbContextfactory = Program.GetService<SalikInventoryManagementDbContextFactory>();
        }

        public Repository(DbContext @object)
        {
            this.@object = @object;
        }

        public async Task<bool> Add(T entity)
        {
           using(InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext())
            {
               var ToBeReturned=await context.Set<T>().AddAsync(entity);
                await context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<bool> Delete(T entity)
        {
            using (InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext())
            {
                var ToBeReturned = context.Set<T>().Remove(entity);
                await context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            using (InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext())
            {
                var listtoReturn=await context.Set<T>().AsNoTracking().ToListAsync();
                return listtoReturn;
            }
        }

        public async Task<T> GetFirstOrDefault(Expression<Func<T, bool>> filter)
        {
            using (InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext())
            {
                var firstOrDefaultTarget= await context.Set<T>().AsNoTracking().FirstOrDefaultAsync(filter);
                return firstOrDefaultTarget;
            }
        }

        public async Task<bool> RemoveRange(IEnumerable<T> entity)
        {
            using (InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext())
            {
               context.Set<T>().RemoveRange(entity);
                await context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<T> Update(T entity)
        {
            using (InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext())
            {
               context.Set<T>().Update(entity);
                await context.SaveChangesAsync();
                return entity;
            }
        }

        
    }
}
