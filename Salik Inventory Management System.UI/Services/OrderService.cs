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
    public class OrderService
    {
        public OrderRepository repository;
        public OrderService()
        {
            repository = new OrderRepository();
        }
        
        public IAsyncEnumerable<OrderModel> GetAllFully()
        {
            return repository.GetAllFully();
        }

        public async Task<OrderModel> GetFirstOrDefaultFully(int id)
        {
            return await repository.GetFirstOrDefaultFully(id);
        }


        public async Task<bool> Add(OrderModel entity)
        {
            return await repository.Add(entity);
        }

        public async Task<bool> Delete(OrderModel entity)
        {
            return await repository.Delete(entity);
        }

        public async Task<IEnumerable<OrderModel>> GetAll()
        {
            return await repository.GetAll();
        }

        public async Task<OrderModel> GetFirstOrDefault(Expression<Func<OrderModel, bool>> filter)
        {
            return await repository.GetFirstOrDefault(filter);
        }

        public async Task<bool> RemoveRange(IEnumerable<OrderModel> entity)
        {
            return await repository.RemoveRange(entity);
        }

        public async Task<OrderModel> Update(OrderModel entity)
        {
            return await repository.Update(entity);
        }
    }
}
