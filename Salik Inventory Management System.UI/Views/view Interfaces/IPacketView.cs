using Salik_Inventory_Management_System.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salik_Inventory_Management_System.UI.Views.view_Interfaces
{
    public interface IPacketView
    {
        //for adding new

        string? ItemName { get; set; }

        string ItemPrice { get; set; }
        string ItemBuyingPrice { get; set; }
        string ItemQuantity { get; set; }
         string? Description { get; set; }
        //for edit
        string IdEdit { get; set; }
        string? ItemNameedit { get; set; }

        string ItemPriceedit { get; set; }
        string ItemBuyingPriceEdit { get; set; }

        string ItemQuantityedit { get; set; }
        string? Descriptionedit { get; set; }

        string searchValue { get; set; }                    
        bool IsSuccessful { get; set; }
        string Message { get; set; }
        string updateQuantityPrompt { get; set; }
        event EventHandler SearchEvent;
        event EventHandler editEvent;
        event EventHandler saveEditedEvent;
        event EventHandler ReturnToHomeEvent;
        event EventHandler deleteEvent;
        event EventHandler addEvent;
        event EventHandler saveNewlyaddedEvent;
        event EventHandler UpdateQuantity;

        event EventHandler RefreshGrid;
        event EventHandler cleanNewFormsBoxes;
        event EventHandler sortByPrice;
        event EventHandler sortByQuantity;

        bool byprie { get;  }
        bool byquantity { get;  }
        bool nosort { get;  }
        void setPacketBindingSource(BindingSource packetList);
        public void Show();
    }
}
