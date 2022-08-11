

using System.ComponentModel.DataAnnotations;

namespace Salik_Inventory_Management_System.UI.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="ناوى كريار نابيت به تال بيت")]
        public string FullName { get; set; }
        public List<Payment>? payments { get; set; }
        public List<OrderModel>? Orders { get; set; }
        public string? Description { get; set; }
    }
}
