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
        event EventHandler addPayment;
        event EventHandler removePayment;
        event EventHandler updatePayment;
        event EventHandler saveUpdatePayment;
        string TabName { get; set; }
        string LabelName { get; set; }
        string MoneyOwed { get; set; }
        string newPaymentAmmountToAdd { get; set; }
        string IdEdit { get; set; }
        string DateEdit { get; set; }
        string PaymentAmountEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }
        string searchvalue { get; set; }
        void setCustomerBindingSource(BindingSource customerList);
        void setPaymentBindingSource(BindingSource paymentList);
        event EventHandler RefreshCustomerGrid;
        event EventHandler RefreshPaymentGrid;
        event EventHandler ChangeSelectedCustomer;
        event EventHandler searchEvent;
        public void Show();
    }
}
