using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salik_Inventory_Management_System.UI.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        public OrderModel? order { get; set; }
        public int? OrderModelId { get; set; }

        public ItemModel? item { get; set; }
        public int? ItemModelId { get; set; }
        [Required(ErrorMessage = " نابيت به تال بيت")]

        public DateTime? DateAdded { get; set; }
        [Required(ErrorMessage ="زماره ى كالأ بنوسه")]
        public int? Quantity { get; set; }
        [Required(ErrorMessage = "نرخ نابيت به تال بيت")]
        [MinLength(1, ErrorMessage = "  نرخ ده بئ له 1 دؤلار زياتر بيت")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal? Price { get; set; }
        public string? description { get; set; }
        public bool? IsHalf { get; set; }
        public bool? IsQuarter { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? PriceTotal { get; set; }
    }
}
