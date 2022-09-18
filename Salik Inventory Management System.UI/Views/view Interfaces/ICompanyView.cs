using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salik_Inventory_Management_System.UI.Views.view_Interfaces
{
    public interface ICompanyView
    {
        string interestMoney { get; set; }
        string totalMoneyReceivedFromCustomers { get; set; }
        string TotalMoneyOwedByCustomer { get; set; }
        string PaymentAmount { get; set; }
        string Id { get; set; }
        string PaymentDate { get; set; }
        string PaymentAmountEdit { get; set; }
        public void Show();
        void setPaymentBindingSource(BindingSource paymentList);
        event EventHandler RefreshPaymentGrid;
        event EventHandler addPayment;
        event EventHandler removePayment;
        event EventHandler updatePayment;
        event EventHandler saveUpdatePayment;
        event EventHandler RefreshHomeTab;
        bool IsSuccessful { get; set; }
        string Message { get; set; }

    }
}
