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

        public IEnumerable<OrderItem> GetAllFully()
        {
            return repository.GetAllFully();
        }

        public  OrderItem GetFirstOrDefaultFully(int id)
        {
            return  repository.GetFirstOrDefaultFully(id);
        }


        public bool Add(OrderItem entity)
        {
            return  repository.Add(entity);
        }

        public bool Delete(OrderItem entity)
        {
            return  repository.Delete(entity);
        }

        public IEnumerable<OrderItem> GetAll()
        {
            return  repository.GetAll();
        }

        public OrderItem GetFirstOrDefault(Expression<Func<OrderItem, bool>> filter)
        {
            return  repository.GetFirstOrDefault(filter);
        }

        public bool RemoveRange(IEnumerable<OrderItem> entity)
        {
            return  repository.RemoveRange(entity);
        }

        public OrderItem Update(OrderItem entity)
        {
            return  repository.Update(entity);
        }
    }
}
