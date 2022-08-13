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
        
        public IAsyncEnumerable<ItemModel> GetAllFully()
        {
            return repository.GetAllFully();
        }

        public async Task<ItemModel> GetFirstOrDefaultFully(int id)
        {
            return await repository.GetFirstOrDefaultFully(id);
        }


        public async Task<bool> Add(ItemModel entity)
        {
            return await repository.Add(entity);
        }

        public async Task<bool> Delete(ItemModel entity)
        {
            return await repository.Delete(entity);
        }

        public async Task<IEnumerable<ItemModel>> GetAll()
        {
            return await repository.GetAll();
        }

        public async Task<ItemModel> GetFirstOrDefault(Expression<Func<ItemModel, bool>> filter)
        {
            return await repository.GetFirstOrDefault(filter);
        }

        public async Task<bool> RemoveRange(IEnumerable<ItemModel> entity)
        {
            return await repository.RemoveRange(entity);
        }

        public async Task<ItemModel> Update(ItemModel entity)
        {
            return await repository.Update(entity);
        }
    }
}
