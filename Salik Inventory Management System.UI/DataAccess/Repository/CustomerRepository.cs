using Microsoft.EntityFrameworkCore;
using Salik_Inventory_Management_System.UI.DataAccess.Repository.IRepository;
using Salik_Inventory_Management_System.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salik_Inventory_Management_System.UI.DataAccess.Repository
{
    public class CustomerRepository : Repository<CustomerModel>, IGetDataFullyWithAttributes<CustomerModel>
    {
        private readonly SalikInventoryManagementDbContextFactory _dbContextfactory;

        public CustomerRepository()
        {
            _dbContextfactory = Program.GetService<SalikInventoryManagementDbContextFactory>();
        }
        public IEnumerable<CustomerModel> GetAllFully()
        {
            using (InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext())
            {
                var fullListwithAttributtes = context.Customers.
                   Include(d => d.payments)
                   .Include(d => d.Orders)
                    .ThenInclude(d => d.Invoices)
                   .Include(k=>k.Orders)
                    .ThenInclude(s=>s.orderedItems).AsNoTracking().AsEnumerable();

                 return fullListwithAttributtes;
            }
        }

        public CustomerModel GetFirstOrDefaultFully(int id)
        {
            using (InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext())
            {
                var firstordefault =  context.Customers.
                   Include(d => d.payments)
                   .Include(d => d.Orders)
                    .ThenInclude(d => d.Invoices)
                   .Include(k => k.Orders)
                    .ThenInclude(s => s.orderedItems).AsNoTracking().FirstOrDefault(k=>k.Id==id);

                return firstordefault;
            }
        }

        public IEnumerable<CustomerModel> GetAllSortedByTotalMoneyOwed()
        {
            InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext();
            
                var fullListwithAttributtes = context.Customers
                  .OrderByDescending(d=>d.TotalMoneyOwed)
                  .AsNoTracking().AsEnumerable();

                return fullListwithAttributtes;
            
        }

        public IEnumerable<CustomerModel> SearchByName(string searchValue)
        {


            InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext();
            var searchResult = context.Customers.AsNoTracking().Where(d => d.FullName.Contains(searchValue)).AsEnumerable();

            return searchResult;


        }

        public IEnumerable<CustomerModel> SearchByNameAndOrderByTotalMoneyOwed(string searchValue)
        {


            InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext();
            var searchResult = context.Customers.AsNoTracking().Where(d => d.FullName.Contains(searchValue)).OrderByDescending(d=>d.TotalMoneyOwed).AsEnumerable();

            return searchResult;


        }
    }
}
