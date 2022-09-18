using Salik_Inventory_Management_System.UI.DataAccess.Repository;
using Salik_Inventory_Management_System.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salik_Inventory_Management_System.UI.Services
{
    public class UserService
    {
        UserRepository repository;
        public UserService()
        {
            repository = new UserRepository();

        }




        public User GetFirstOrDefaultFully()
        {
            return repository.GetFirstOrDefault(d => d.Id == 1);
        }
       

       

        public User Update(User entity)
        {
            return repository.Update(entity);
        }
    }
}
