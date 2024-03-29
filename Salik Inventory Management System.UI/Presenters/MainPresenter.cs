﻿using Salik_Inventory_Management_System.UI.Views;
using Salik_Inventory_Management_System.UI.Views.view_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salik_Inventory_Management_System.UI.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        IPacketView packetView;
        PacketPresenter packetPresenter;
        ICustomerView customerView;
        CustomerPresenter customerPresenter;
        IPaymentView paymentView;
        PaymentPresenter paymentPresenter;
        IOrderView orderView;
        OrderPresenter orderPresenter;
        ICompanyView companyView;
        CompanyPresenter companyPresenter;
        
        public MainPresenter(IMainView mainView)
        {
            this.mainView = mainView;
            this.mainView.ShowPacketNav += ShowPacketNav;
            this.mainView.ShowCustomerNav += ShowCustomerNav;
            this.mainView.ShowPaymentNav += ShowPaymentNav;
            this.mainView.ShowOrderNav += ShowOrderNav;
            this.mainView.ShowCompanyNav += ShowCompanyNav;
            packetView = PacketView.GetInstace((MainView)mainView);
            packetPresenter = PacketPresenter.GetInstace(packetView);

            customerView = CustomerView.GetInstace((MainView)mainView);
            customerPresenter = CustomerPresenter.GetInstace(customerView);

            paymentView = PaymentView.GetInstace((MainView)mainView);
            paymentPresenter=PaymentPresenter.GetInstace(paymentView);

            orderView = OrderView.GetInstace((MainView)mainView);
            orderPresenter=OrderPresenter.GetInstace(orderView);

            companyView = CompanyView.GetInstace((Form)mainView);
            companyPresenter=CompanyPresenter.GetInstace(companyView);

        }

        public void ShowPacketNav(object sender, EventArgs e)
        {
            //will cause duplicate presenter if we declare a new presenter everytime
            //PacketPresenter presenter =  new PacketPresenter(packetView);
            packetView = PacketView.GetInstace((MainView)mainView);
            packetPresenter = PacketPresenter.GetInstace(packetView);
            packetPresenter.showView();

        }

        public void ShowCompanyNav(object sender, EventArgs e)
        {

            companyView = CompanyView.GetInstace((Form)mainView);
            companyPresenter = CompanyPresenter.GetInstace(companyView);
            companyPresenter.showView();
        }
        

        public void ShowCustomerNav(object sender, EventArgs e)
        {

            customerView = CustomerView.GetInstace((MainView)mainView);
            customerPresenter = CustomerPresenter.GetInstace(customerView);
            //will cause duplicate presenter if we declare a new presenter everytime
            //PacketPresenter presenter =  new PacketPresenter(packetView);
            customerPresenter.showView();
        }

        public void ShowPaymentNav(object sender,EventArgs e)
        {
            paymentView = PaymentView.GetInstace((MainView)mainView);
            paymentPresenter = PaymentPresenter.GetInstace(paymentView);

            paymentPresenter.showView();
        }
        public void ShowOrderNav(object sender, EventArgs e)
        {
            orderView = OrderView.GetInstace((MainView)mainView);
            orderPresenter = OrderPresenter.GetInstace(orderView);

            orderPresenter.showView();
        }
        
    }
}
