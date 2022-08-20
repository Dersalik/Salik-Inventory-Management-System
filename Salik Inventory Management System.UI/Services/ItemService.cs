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
    public class ItemService
    {
        public ItemRepository repository;
        public ItemService()
        {
            repository = new ItemRepository();
        }
        
        public IEnumerable<ItemModel> GetAllFully()
        {
            return repository.GetAllFully();
        }

        public ItemModel GetFirstOrDefaultFully(int id)
        {
            return  repository.GetFirstOrDefaultFully(id);
        }


        public bool Add(ItemModel entity)
        {
            return  repository.Add(entity);
        }

        public bool Delete(ItemModel entity)
        {
            return  repository.Delete(entity);
        }

        public IEnumerable<ItemModel> GetAll()
        {
            return  repository.GetAll();
        }

        public ItemModel GetFirstOrDefault(Expression<Func<ItemModel, bool>> filter)
        {
            return  repository.GetFirstOrDefault(filter);
        }

        public bool RemoveRange(IEnumerable<ItemModel> entity)
        {
            return  repository.RemoveRange(entity);
        }

        public ItemModel Update(ItemModel entity)
        {
            return  repository.Update(entity);
        }
        public IEnumerable<ItemModel> SearchByName(string searchValue)
        {
            return  repository.SearchByName(searchValue);
        }


        public IEnumerable<ItemModel> GetAllSortedByPrice()
        {
            return repository.GetAllSortedByPrice();
        }
        public IEnumerable<ItemModel> GetAllSortedByQuantity()
        {
            return repository.GetAllSortedByQuantity();
        }

    }
}
