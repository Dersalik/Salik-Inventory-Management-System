﻿using Microsoft.EntityFrameworkCore;
using Salik_Inventory_Management_System.UI.DataAccess.Repository.IRepository;
using Salik_Inventory_Management_System.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salik_Inventory_Management_System.UI.DataAccess.Repository
{
    public class PaymentRepository :Repository<Payment>, IGetDataFullyWithAttributes<Payment>
    {
        private readonly SalikInventoryManagementDbContextFactory _dbContextfactory;

        public PaymentRepository()
        {
            _dbContextfactory = Program.GetService<SalikInventoryManagementDbContextFactory>();
        }
        public IEnumerable<Payment> GetAllFully()
        {
            using (InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext())
            {
                var fullListwithAttributtes = context.Payments.Include(d => d.Customer).AsNoTracking().AsEnumerable();

                 return fullListwithAttributtes;
            }
        }

        public Payment GetFirstOrDefaultFully(int id)
        {
            using (InventoryManagementSystemDbContext context = _dbContextfactory.CreateDbContext())
            {
                var firstordefault =  context.Payments.Include(d => d.Customer).AsNoTracking().FirstOrDefault(d => d.Id == id);

                return firstordefault;
            }
        }


    }
}
