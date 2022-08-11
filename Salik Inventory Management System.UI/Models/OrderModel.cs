using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Salik_Inventory_Management_System.UI.Models
{

    public class OrderModel
    {
        public int Id { get; set; }
        
        public CustomerModel? customerModel { get; set; }
        public int? CustomerModelId { get; set; }
        public List<OrderItem>? orderedItems { get; set; }
        public List<InvoiceModel>? Invoices { get; set; }
        [Required(ErrorMessage = " نابيت به تال بيت")]
        public DateTime? OrderDate { get; set; }
        public string? Description { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? TotalPaymentAmount { get; set; }//sum of all PriceTotals beloning to that order
        [Column(TypeName = "decimal(18,4)")]
        public decimal discount { get; set; } = decimal.Zero;


    }
}
