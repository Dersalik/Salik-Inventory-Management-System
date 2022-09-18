using System.ComponentModel.DataAnnotations.Schema;


namespace Salik_Inventory_Management_System.UI.Models
{
    public class CompanyPayment
    {
        public int Id { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public MardCompany? company { get; set; }
        public int? MardCompanyId { get; set; }
    }
}
