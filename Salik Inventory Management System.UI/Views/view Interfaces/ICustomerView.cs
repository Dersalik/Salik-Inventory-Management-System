using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salik_Inventory_Management_System.UI.Views.view_Interfaces
{
    public interface ICustomerView
    {
        void setCustomerBindingSource(BindingSource CustomerList);
        public void Show();
    }
}
