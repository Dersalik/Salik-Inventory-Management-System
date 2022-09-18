using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salik_Inventory_Management_System.UI.Models
{
    public class MardCompany
    {
        public int Id { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal TotalMoneyOwedByUserToTheCompany { get; set; }
        public List<ItemModel>? Items { get; set; }
        public List<CompanyPayment>? PaymentsReceivedFromTheUser { get; set; }
    }
}
