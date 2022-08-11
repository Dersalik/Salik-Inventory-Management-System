using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Salik_Inventory_Management_System.UI.Models
{
    public class ItemModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "ناوى كالأ نابيت به تال بيت")]
        public string ItemName { get; set; }
        [Required(ErrorMessage = "نرخ نابيت به تال بيت")]
        [MinLength(1,ErrorMessage ="  نرخ ده بئ له 1 دؤلار زياتر بيت")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal ItemPrice {get;set;}
        public List<OrderItem>? ItemOrderedList { get; set; }
        [Required(ErrorMessage = " نابيت به تال بيت")]
        [MinLength(1, ErrorMessage = "ده بئ له 1 زياتر بيت")]
        public double ItemQuantity { get; set; }
        public string? Description { get; set; }

    }
}
