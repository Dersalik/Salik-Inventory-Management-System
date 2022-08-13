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
    public class OrderRepository :Repository<OrderModel>, IGetDataFullyWithAttributes<OrderModel>
    {
        private readonly SalikInventoryManagementDbContextFactory _dbContextfactory;

        public OrderRepository()
        {
            _dbContextfactory = Program.GetService<SalikInventoryManagementDbContextFactory>();
        }
        public IAsyncEnumerable<OrderModel> GetAllFully()
        {
            using (InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext())
            {
                var fullListwithAttributtes =  context.Orders
                    .Include(f=>f.orderedItems)
                    .Include(f=>f.Invoices)
                    .Include(c=>c.customerModel)
                    .AsNoTracking()
                    .AsAsyncEnumerable();
                    
                   

                 return fullListwithAttributtes;
            }
        }

        public async Task<OrderModel> GetFirstOrDefaultFully(int id)
        {
            using (InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext())
            {
                var firstordefault =await context.Orders
                    .Include(f => f.orderedItems)
                    .Include(f => f.Invoices)
                    .Include(c => c.customerModel)
                    .AsNoTracking()
                    .FirstOrDefaultAsync(d=>d.Id==id);



                return firstordefault;
            }
        }

        public async Task<IAsyncEnumerable<OrderModel>> getAllOrdersByIdOfCustomer(int id)
        {
            using (InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext())
            {
                var ordersOfTheCustomer =  context.Orders
                    .Include(f => f.orderedItems)
                    .Include(f => f.Invoices)
                    .Include(c => c.customerModel)
                    .AsNoTracking()
                    .Where(d=>d.CustomerModelId==id).AsAsyncEnumerable();



                return ordersOfTheCustomer;
            }
        }


    }
}
