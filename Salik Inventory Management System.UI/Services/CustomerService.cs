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
    public class CustomerService
    {
        public CustomerRepository repository;
        public CustomerService()
        {
            repository=new CustomerRepository();
        }

        public IAsyncEnumerable<CustomerModel> GetAllFully()
        {
            return repository.GetAllFully();
        }

        public async Task<CustomerModel> GetFirstOrDefaultFully(int id)
        {
            return await repository.GetFirstOrDefaultFully(id);
        }


        public async Task<bool> Add(CustomerModel entity)
        {
            return await repository.Add(entity);
        }

        public async Task<bool> Delete(CustomerModel entity)
        {
           return await repository.Delete(entity);
        }

        public async Task<IEnumerable<CustomerModel>> GetAll()
        {
            return await  repository.GetAll();
        }

        public async Task<CustomerModel> GetFirstOrDefault(Expression<Func<CustomerModel, bool>> filter)
        {
            return  await repository.GetFirstOrDefault(filter);
        }

        public async Task<bool> RemoveRange(IEnumerable<CustomerModel> entity)
        {
            return await repository.RemoveRange(entity);
        }

        public async Task<CustomerModel> Update(CustomerModel entity)
        {
           return await repository.Update(entity);
        }
    }
}
