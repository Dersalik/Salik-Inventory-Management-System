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
        public bool Add(T entity);
        public T GetFirstOrDefault(Expression<Func<T, bool>> filter);
        public IEnumerable<T> GetAll();
        public bool RemoveRange(IEnumerable<T> entity);
        public T Update(T entity);
        public bool Delete(T entity);


    }
}
