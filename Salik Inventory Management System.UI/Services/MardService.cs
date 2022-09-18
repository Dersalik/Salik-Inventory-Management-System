using Salik_Inventory_Management_System.UI.DataAccess.Repository;
using Salik_Inventory_Management_System.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salik_Inventory_Management_System.UI.Services
{
    public class MardService
    {
        MardCompanyRepository repository;
        public MardService()
        {
            repository = new MardCompanyRepository();

        }




        public MardCompany GetFirstOrDefaultFully()
        {
            return repository.GetFirstOrDefault(d=>d.Id==1);
        }




        public MardCompany Update(MardCompany entity)
        {
            return repository.Update(entity);
        }
    }
}
