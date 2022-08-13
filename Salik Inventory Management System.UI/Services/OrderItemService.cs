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
    public class OrderItemService
    {
        public OrderedItemRepository repository;
        public OrderItemService()
        {
            repository = new OrderedItemRepository();
        }

        public IAsyncEnumerable<OrderItem> GetAllFully()
        {
            return repository.GetAllFully();
        }

        public async Task<OrderItem> GetFirstOrDefaultFully(int id)
        {
            return await repository.GetFirstOrDefaultFully(id);
        }


        public async Task<bool> Add(OrderItem entity)
        {
            return await repository.Add(entity);
        }

        public async Task<bool> Delete(OrderItem entity)
        {
            return await repository.Delete(entity);
        }

        public async Task<IEnumerable<OrderItem>> GetAll()
        {
            return await repository.GetAll();
        }

        public async Task<OrderItem> GetFirstOrDefault(Expression<Func<OrderItem, bool>> filter)
        {
            return await repository.GetFirstOrDefault(filter);
        }

        public async Task<bool> RemoveRange(IEnumerable<OrderItem> entity)
        {
            return await repository.RemoveRange(entity);
        }

        public async Task<OrderItem> Update(OrderItem entity)
        {
            return await repository.Update(entity);
        }
    }
}
