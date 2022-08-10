using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Salik_Inventory_Management_System.UI.Models
{
    public enum OrderPaymentStatus
    {
        OrderPaymentFinished,
        OrderPaymentRemaining,
        OrderPaymentUnpaid
    }
    public class OrderModel
    {
        public int Id { get; set; }
        
        public CustomerModel? customerModel { get; set; }
        public int? CustomerModelId { get; set; }
        public List<Payment>? payments { get; set; }
        public List<OrderItem>? orderedItems { get; set; }
        public int InvoiceId { get; set; }
        public List<InvoiceModel>? Invoices { get; set; }
        [Required(ErrorMessage = " نابيت به تال بيت")]
        public DateTime? OrderDate { get; set; }
        public string? Description { get; set; }
        public OrderPaymentStatus? orderPaymentStatus { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? TotalPaymentAmount { get; set; }//sum of all PriceTotals beloning to that order
        [Column(TypeName = "decimal(18,4)")]
        public decimal? OrderAmountPaid { get; set; }//sum of all amounts in the payment belonging to that order 
        [Column(TypeName = "decimal(18,4)")]
        public decimal? OrderAmountRemaing { get; set; }//TotalPaymentAmount-OrderAmountPaid
    }
}
