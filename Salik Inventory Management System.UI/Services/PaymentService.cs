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
    public class PaymentService
    {
        public PaymentRepository repository;
        public PaymentService()
        {
            repository = new PaymentRepository();
        }

        public IAsyncEnumerable<Payment> GetAllFully()
        {
            return repository.GetAllFully();
        }

        public async Task<Payment> GetFirstOrDefaultFully(int id)
        {
            return await repository.GetFirstOrDefaultFully(id);
        }


        public async Task<bool> Add(Payment entity)
        {
            return await repository.Add(entity);
        }

        public async Task<bool> Delete(Payment entity)
        {
            return await repository.Delete(entity);
        }

        public async Task<IEnumerable<Payment>> GetAll()
        {
            return await repository.GetAll();
        }

        public async Task<Payment> GetFirstOrDefault(Expression<Func<Payment, bool>> filter)
        {
            return await repository.GetFirstOrDefault(filter);
        }

        public async Task<bool> RemoveRange(IEnumerable<Payment> entity)
        {
            return await repository.RemoveRange(entity);
        }

        public async Task<Payment> Update(Payment entity)
        {
            return await repository.Update(entity);
        }
    }
}
