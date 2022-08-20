using Microsoft.EntityFrameworkCore;
using Salik_Inventory_Management_System.UI.DataAccess.Repository.IRepository;
using Salik_Inventory_Management_System.UI.Models;


namespace Salik_Inventory_Management_System.UI.DataAccess.Repository
{
    public class OrderedItemRepository :Repository<OrderItem>, IGetDataFullyWithAttributes<OrderItem>
    {
        private readonly SalikInventoryManagementDbContextFactory _dbContextfactory;

        public OrderedItemRepository()
        {
            _dbContextfactory = Program.GetService<SalikInventoryManagementDbContextFactory>();
        }
        public IEnumerable<OrderItem> GetAllFully()
        {
            using (InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext())
            {
                var fullListwithAttributtes = context.OrderItem.Include(d=>d.order).AsNoTracking().AsEnumerable();

                 return fullListwithAttributtes;
            }
        }

        public OrderItem GetFirstOrDefaultFully(int id)
        {
            using (InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext())
            {
                var firstordefault = context.OrderItem.Include(d => d.order).AsNoTracking().FirstOrDefault(d=>d.Id==id);

                return firstordefault;
            }
        }


    }
}
