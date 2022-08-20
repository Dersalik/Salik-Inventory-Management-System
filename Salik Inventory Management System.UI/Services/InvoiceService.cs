using Salik_Inventory_Management_System.UI.DataAccess.Repository;
using Salik_Inventory_Management_System.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Salik_Inventory_Management_System.UI.Services
{
    public class InvoiceService
    {

        public InvoiceRepository repository;
        public InvoiceService()
        {
            repository = new InvoiceRepository();
        }
        
        public IEnumerable<InvoiceModel> GetAllFully()
        {
            return repository.GetAllFully();
        }

        public InvoiceModel GetFirstOrDefaultFully(int id)
        {
            return  repository.GetFirstOrDefaultFully(id);
        }


        public bool Add(InvoiceModel entity)
        {
            return  repository.Add(entity);
        }

        public bool Delete(InvoiceModel entity)
        {
            return  repository.Delete(entity);
        }

        public IEnumerable<InvoiceModel> GetAll()
        {
            return  repository.GetAll();
        }

        public InvoiceModel GetFirstOrDefault(Expression<Func<InvoiceModel, bool>> filter)
        {
            return  repository.GetFirstOrDefault(filter);
        }

        public bool RemoveRange(IEnumerable<InvoiceModel> entity)
        {
            return  repository.RemoveRange(entity);
        }

        public InvoiceModel Update(InvoiceModel entity)
        {
            return  repository.Update(entity);
        }
    }
}
