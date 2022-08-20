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
        
        public IEnumerable<OrderModel> GetAllFully()
        {
            return repository.GetAllFully();
        }

        public OrderModel GetFirstOrDefaultFully(int id)
        {
            return  repository.GetFirstOrDefaultFully(id);
        }


        public bool Add(OrderModel entity)
        {
            return  repository.Add(entity);
        }

        public bool Delete(OrderModel entity)
        {
            return  repository.Delete(entity);
        }

        public IEnumerable<OrderModel> GetAll()
        {
            return  repository.GetAll();
        }

        public OrderModel GetFirstOrDefault(Expression<Func<OrderModel, bool>> filter)
        {
            return  repository.GetFirstOrDefault(filter);
        }

        public bool RemoveRange(IEnumerable<OrderModel> entity)
        {
            return  repository.RemoveRange(entity);
        }

        public OrderModel Update(OrderModel entity)
        {
            return  repository.Update(entity);
        }
    }
}
