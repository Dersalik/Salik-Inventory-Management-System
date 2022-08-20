using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salik_Inventory_Management_System.UI.DataAccess.Repository.IRepository
{
    public interface IGetDataFullyWithAttributes<T> where T : class
    {
        public IEnumerable<T> GetAllFully();
        public  T GetFirstOrDefaultFully(int id);
    }
}
