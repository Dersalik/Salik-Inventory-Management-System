using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salik_Inventory_Management_System.UI.Models
{
    public class InvoiceModel
    {
        public int Id { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public OrderModel? order { get; set; }
        public int? OrderModelId { get; set; }

    }
}
