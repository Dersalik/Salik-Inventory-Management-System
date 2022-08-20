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

        public IEnumerable<Payment> GetAllFully()
        {
            return repository.GetAllFully();
        }

        public Payment GetFirstOrDefaultFully(int id)
        {
            return  repository.GetFirstOrDefaultFully(id);
        }


        public bool Add(Payment entity)
        {
            return  repository.Add(entity);
        }

        public bool Delete(Payment entity)
        {
            return  repository.Delete(entity);
        }

        public IEnumerable<Payment> GetAll()
        {
            return  repository.GetAll();
        }

        public Payment GetFirstOrDefault(Expression<Func<Payment, bool>> filter)
        {
            return  repository.GetFirstOrDefault(filter);
        }

        public bool RemoveRange(IEnumerable<Payment> entity)
        {
            return  repository.RemoveRange(entity);
        }

        public Payment Update(Payment entity)
        {
            return  repository.Update(entity);
        }
    }
}
