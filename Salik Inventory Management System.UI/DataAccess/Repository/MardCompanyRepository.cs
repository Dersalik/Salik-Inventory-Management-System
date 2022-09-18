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
    public class MardCompanyRepository : Repository<MardCompany>
    {
        private readonly SalikInventoryManagementDbContextFactory _dbContextfactory;

        public MardCompanyRepository()
        {
            _dbContextfactory = Program.GetService<SalikInventoryManagementDbContextFactory>();
        }
      
        public MardCompany GetMardFully()
        {
            using (InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext())
            {

                return context.mardCompany.Include(d => d.PaymentsReceivedFromTheUser)
                     .Include(d => d.Items).AsNoTracking().FirstOrDefault();
            }
        }

        public MardCompany GetMard()
        {
            using (InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext())
            {

                return context.mardCompany.AsNoTracking().FirstOrDefault();
            }
        }


    }
}
