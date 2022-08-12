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
    public class InvoiceRepository :Repository<InvoiceModel>, IGetDataFullyWithAttributes<InvoiceModel>
    {
        private readonly SalikInventoryManagementDbContextFactory _dbContextfactory;

        public InvoiceRepository()
        {
            _dbContextfactory = Program.GetService<SalikInventoryManagementDbContextFactory>();
        }
        public  IAsyncEnumerable<InvoiceModel> GetAllFully()
        {
            using (InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext())
            {
                var fullListwithAttributtes =  context.Invoices.Include(c => c.order).AsNoTracking().AsAsyncEnumerable();

                 return fullListwithAttributtes;
            }
        }

        public async Task<InvoiceModel> GetFirstOrDefaultFully(int id)
        {
            using (InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext())
            {
                var getfirstordefault = await context.Invoices.Include(c => c.order).AsNoTracking().FirstOrDefaultAsync(e=>e.Id==id);

                return getfirstordefault;
            }
        }


    }
}
