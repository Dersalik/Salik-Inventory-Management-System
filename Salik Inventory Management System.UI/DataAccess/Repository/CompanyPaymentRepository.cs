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
    public class CompanyPaymentRepository : Repository<CompanyPayment>
    {
        private readonly SalikInventoryManagementDbContextFactory _dbContextfactory;

        public CompanyPaymentRepository()
        {
            _dbContextfactory = Program.GetService<SalikInventoryManagementDbContextFactory>();
        }
      

        
    }
}
