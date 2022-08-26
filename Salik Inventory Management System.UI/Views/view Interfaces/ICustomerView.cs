using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salik_Inventory_Management_System.UI.Views.view_Interfaces
{
    public interface ICustomerView
    {
        //text box variables 
        string fullName { get; set; }
        string description { get; set; }

        string fullnameEdit { get; set; }
        string desEdit { get; set; }
        string IdEdit { get; set; }
        //
        //other variables 
        string searchValue { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }
        bool byOwedMoney { get;}
        bool noSort { get; }
        //

        void setCustomerBindingSource(BindingSource CustomerList);
        public void Show();
        //events
        event EventHandler SearchEvent;
        event EventHandler editEvent;
        event EventHandler saveEditedEvent;
        event EventHandler ReturnToHomeEvent;
        event EventHandler deleteEvent;
        event EventHandler addEvent;
        event EventHandler saveNewlyaddedEvent;
        event EventHandler RefreshGrid;
        event EventHandler cleanNewFormsBoxes;
        event EventHandler SortByMoneyOwed;
        //

    }
}
