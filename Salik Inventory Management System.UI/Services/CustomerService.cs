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

        public IEnumerable<CustomerModel> GetAllFully()
        {
            return repository.GetAllFully();
        }

        public CustomerModel GetFirstOrDefaultFully(int id)
        {
            return  repository.GetFirstOrDefaultFully(id);
        }


        public bool Add(CustomerModel entity)
        {
            return  repository.Add(entity);
        }

        public bool Delete(CustomerModel entity)
        {
           return  repository.Delete(entity);
        }

        public IEnumerable<CustomerModel> GetAll()
        {
            return   repository.GetAll();
        }

        public CustomerModel GetFirstOrDefault(Expression<Func<CustomerModel, bool>> filter)
        {
            return   repository.GetFirstOrDefault(filter);
        }

        public bool RemoveRange(IEnumerable<CustomerModel> entity)
        {
            return  repository.RemoveRange(entity);
        }

        public CustomerModel Update(CustomerModel entity)
        {
           return  repository.Update(entity);
        }
    }
}
