using Microsoft.EntityFrameworkCore;
using Salik_Inventory_Management_System.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salik_Inventory_Management_System.UI.DataAccess.Repository
{
    public class CustomerRepository :Repository<CustomerModel>
    {
        private readonly SalikInventoryManagementDbContextFactory _dbContextfactory;

        public CustomerRepository()
        {
            _dbContextfactory = Program.GetService<SalikInventoryManagementDbContextFactory>();
        }
        public IAsyncEnumerable<CustomerModel> GetAllFully()
        {
            using (InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext())
            {
                var fullListwithAttributtes = context.Customers.
                   Include(d => d.payments)
                   .Include(d => d.Orders)
                    .ThenInclude(d => d.Invoices)
                   .Include(k=>k.Orders)
                    .ThenInclude(s=>s.orderedItems).AsNoTracking().AsAsyncEnumerable();

                 return fullListwithAttributtes;
            }
        }

        public async Task<CustomerModel> GetFirstOrDefaultFully(int id)
        {
            using (InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext())
            {
                var fullListwithAttributtes =await context.Customers.
                   Include(d => d.payments)
                   .Include(d => d.Orders)
                    .ThenInclude(d => d.Invoices)
                   .Include(k => k.Orders)
                    .ThenInclude(s => s.orderedItems).AsNoTracking().FirstOrDefaultAsync(k=>k.Id==id);

                return fullListwithAttributtes;
            }
        }


    }
}
