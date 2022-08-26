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

        public Repository()
        {
            _dbContextfactory = Program.GetService<SalikInventoryManagementDbContextFactory>();
        }


        public bool Add(T entity)
        {
           using(InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext())
            {
                
                 context.Set<T>().Add(entity);
                 context.SaveChanges();
                return true;
            }
        }

        public bool Delete(T entity)
        {
            using (InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext())
            {
                 context.Set<T>().Remove(entity);
                 context.SaveChanges();
                return true;
            }
        }

        public IEnumerable<T> GetAll()
        {
            InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext();
          
                var listtoReturn= context.Set<T>().AsNoTracking().ToList();
                return listtoReturn;
            
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter)
        {
            using (InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext())
            {
                var firstOrDefaultTarget=  context.Set<T>().AsNoTracking().FirstOrDefault(filter);
                return firstOrDefaultTarget;
            }
        }

        public bool RemoveRange(IEnumerable<T> entity)
        {
            using (InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext())
            {
               context.Set<T>().RemoveRange(entity);
               context.SaveChanges();
                return true;
            }
        }

        public T Update(T entity)
        {
            using (InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext())
            {
               context.Set<T>().Update(entity);
                context.SaveChanges();
                return entity;
            }
        }

        
    }
}
