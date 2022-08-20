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
        public IEnumerable<OrderModel> GetAllFully()
        {
            using (InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext())
            {
                var fullListwithAttributtes =  context.Orders
                    .Include(f=>f.orderedItems)
                    .Include(f=>f.Invoices)
                    .Include(c=>c.customerModel)
                    .AsNoTracking()
                    .AsEnumerable();
                    
                   

                 return fullListwithAttributtes;
            }
        }

        public OrderModel GetFirstOrDefaultFully(int id)
        {
            using (InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext())
            {
                var firstordefault = context.Orders
                    .Include(f => f.orderedItems)
                    .Include(f => f.Invoices)
                    .Include(c => c.customerModel)
                    .AsNoTracking()
                    .FirstOrDefault(d=>d.Id==id);



                return firstordefault;
            }
        }

        public IEnumerable<OrderModel> getAllOrdersByIdOfCustomer(int id)
        {
            using (InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext())
            {
                var ordersOfTheCustomer =  context.Orders
                    .Include(f => f.orderedItems)
                    .Include(f => f.Invoices)
                    .Include(c => c.customerModel)
                    .AsNoTracking()
                    .Where(d=>d.CustomerModelId==id).AsEnumerable();



                return ordersOfTheCustomer;
            }
        }


    }
}
