

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Salik_Inventory_Management_System.UI.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="ناوى كريار نابيت به تال بيت")]
        public string? FullName { get; set; }
        public List<Payment>? payments { get; set; }
        public List<OrderModel>? Orders { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? TotalMoneyOwed { get; set; } = decimal.Zero;
        public string? Description { get; set; }
    }
}
