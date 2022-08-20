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
        public IEnumerable<ItemModel> GetAllFully()
        {
            using (InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext()) { 
            
                var fullListwithAttributtes = context.Items.Include(d => d.ItemOrderedList)
                    .AsNoTracking().AsEnumerable();
                 
                 return fullListwithAttributtes;
            }

        }

        public ItemModel GetFirstOrDefaultFully(int id)
        {
            using (InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext())
            {
                var firstordefault = context.Items.Include(d => d.ItemOrderedList)
                                    .AsNoTracking().FirstOrDefault(d => d.Id == id);
                return firstordefault;
            }
           
            
        }
      

        public IEnumerable<ItemModel> SearchByName(string searchValue)
        {


          InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext();
                var searchResult =  context.Items.AsNoTracking().Where(d => d.ItemName.Contains(searchValue)).AsEnumerable();
               
                return searchResult;
            

        }

        public IEnumerable<ItemModel> GetAllSortedByPrice()
        {


            InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext();
            var searchResult = context.Items.AsNoTracking().OrderByDescending(d=>d.ItemPrice).AsEnumerable();

            return searchResult;


        }


        public IEnumerable<ItemModel> GetAllSortedByQuantity()
        {


            InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext();
            var searchResult = context.Items.AsNoTracking().OrderByDescending(d => d.ItemQuantity).AsEnumerable();

            return searchResult;


        }

    }
}
