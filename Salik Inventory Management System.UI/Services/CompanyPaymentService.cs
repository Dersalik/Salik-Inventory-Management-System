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
    public class CompanyPaymentService
    {
        public CompanyPaymentRepository repository;
        public CompanyPaymentService()
        {
            repository = new CompanyPaymentRepository();
        }

        


        public bool Add(CompanyPayment entity)
        {
            return repository.Add(entity);
        }

        public bool Delete(CompanyPayment entity)
        {
            return repository.Delete(entity);
        }

        public IEnumerable<CompanyPayment> GetAll()
        {
            return repository.GetAll();
        }

        public CompanyPayment GetFirstOrDefault(Expression<Func<CompanyPayment, bool>> filter)
        {
            return repository.GetFirstOrDefault(filter);
        }

        public bool RemoveRange(IEnumerable<CompanyPayment> entity)
        {
            return repository.RemoveRange(entity);
        }

        public CompanyPayment Update(CompanyPayment entity)
        {
            return repository.Update(entity);
        }
    }
}
