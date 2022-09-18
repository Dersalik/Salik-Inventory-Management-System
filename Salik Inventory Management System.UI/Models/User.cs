﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salik_Inventory_Management_System.UI.Models
{
    public class User
    {
        public int Id { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal TotalMoneyOwedByCustomers { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal TotalMoneyReceivedFromCustomers { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal TotalGainedMoney { get; set; }
    }
}
