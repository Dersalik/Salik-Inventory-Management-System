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
        
        public IAsyncEnumerable<InvoiceModel> GetAllFully()
        {
            return repository.GetAllFully();
        }

        public async Task<InvoiceModel> GetFirstOrDefaultFully(int id)
        {
            return await repository.GetFirstOrDefaultFully(id);
        }


        public async Task<bool> Add(InvoiceModel entity)
        {
            return await repository.Add(entity);
        }

        public async Task<bool> Delete(InvoiceModel entity)
        {
            return await repository.Delete(entity);
        }

        public async Task<IEnumerable<InvoiceModel>> GetAll()
        {
            return await repository.GetAll();
        }

        public async Task<InvoiceModel> GetFirstOrDefault(Expression<Func<InvoiceModel, bool>> filter)
        {
            return await repository.GetFirstOrDefault(filter);
        }

        public async Task<bool> RemoveRange(IEnumerable<InvoiceModel> entity)
        {
            return await repository.RemoveRange(entity);
        }

        public async Task<InvoiceModel> Update(InvoiceModel entity)
        {
            return await repository.Update(entity);
        }
    }
}
