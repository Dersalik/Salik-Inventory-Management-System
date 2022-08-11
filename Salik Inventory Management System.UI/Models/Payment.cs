using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salik_Inventory_Management_System.UI.Models
{
    public class Payment
    {
       public int Id { get; set; }
       public CustomerModel? Customer { get; set; }
       public int? CustomerModelId { get; set; }
       [Required(ErrorMessage = " نابيت به تال بيت")]
       public DateTime PaymentDate { get; set; }
        [Required(ErrorMessage = " نابيت به تال بيت")]
        [MinLength(1, ErrorMessage = "  نرخ ده بئ له 1 دؤلار زياتر بيت")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal PaymentAmount { get; set; }
       

    }
}
