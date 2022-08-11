using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Salik_Inventory_Management_System.UI.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        public Task<bool> Add(T entity);
        public Task<T> GetFirstOrDefault(Expression<Func<T, bool>> filter);
        public Task<IEnumerable<T>> GetAll();
        public Task<bool> RemoveRange(IEnumerable<T> entity);
        public Task<T> Update(T entity);
        public Task<bool> Delete(T entity);


    }
}
