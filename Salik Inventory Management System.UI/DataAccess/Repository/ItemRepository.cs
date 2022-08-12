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
    public class ItemRepository:Repository<ItemModel>, IGetDataFullyWithAttributes<ItemModel>
    {
        private readonly SalikInventoryManagementDbContextFactory _dbContextfactory;

        public ItemRepository()
        {
            _dbContextfactory = Program.GetService<SalikInventoryManagementDbContextFactory>();
        }
        public IAsyncEnumerable<ItemModel> GetAllFully()
        {
            using (InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext())
            {
                var fullListwithAttributtes = context.Items.Include(d => d.ItemOrderedList)
                    .AsNoTracking().AsAsyncEnumerable();

                 return fullListwithAttributtes;
            }
        }

        public async Task<ItemModel> GetFirstOrDefaultFully(int id)
        {
            using (InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext())
            {
                var firstordefault = await context.Items.Include(d => d.ItemOrderedList)
                    .AsNoTracking().FirstOrDefaultAsync(d => d.Id == id);

                return firstordefault;
            }
        }


    }
}
