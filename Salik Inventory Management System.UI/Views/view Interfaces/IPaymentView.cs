using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salik_Inventory_Management_System.UI.Views.view_Interfaces
{
    public interface IPaymentView
    {
        event EventHandler loadAllPaymentsOfACustomer;
        string TabName { get; set; }
        string LabelName { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }
        void setCustomerBindingSource(BindingSource customerList);
        void setPaymentBindingSource(BindingSource paymentList);
        public void Show();
    }
}
