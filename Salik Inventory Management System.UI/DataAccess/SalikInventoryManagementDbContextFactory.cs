using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Salik_Inventory_Management_System.UI.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salik_Inventory_Management_System.UI.DataAccess
{
    public class SalikInventoryManagementDbContextFactory : IDesignTimeDbContextFactory<InventoryManagementSystemDbContext>
    {
        public InventoryManagementSystemDbContext CreateDbContext(string[] args=null)
        {
            var options = new DbContextOptionsBuilder<InventoryManagementSystemDbContext>();
         
            options.UseSqlServer(Program.ConncetionString).EnableDetailedErrors(true);

            return new InventoryManagementSystemDbContext(options.Options);
        }
    }
}
