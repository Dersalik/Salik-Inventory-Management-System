using Salik_Inventory_Management_System.UI;
using Salik_Inventory_Management_System.UI.Models;
using Salik_Inventory_Management_System.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salik_Inventory_Management_System.Tests.ServicesUnitTests
{
    public class CustomerServiceTest
    {
        [Fact]
        
        public async void testAdding()
        {
            Program.ConfigureServices();
            CustomerService service = new CustomerService();
            var resultbefore = await service.GetAll();
            int countbefore = resultbefore.Count();

            CustomerModel testobj = new CustomerModel() { FullName = "قادر ره ش" };

             service.Add(testobj);
            var resultafter = await service.GetAll();
            int countafter = resultafter.Count();

            Assert.False(countbefore < countafter);
           
        }
        [Fact]
        public async void testDeletion()
        {
            Program.ConfigureServices();
            CustomerService service = new CustomerService();
            var resultbefore = await service.GetAll();
            int countbefore = resultbefore.Count();

            CustomerModel testobj = new CustomerModel() { FullName = "قادر ره ش" };

            service.Add(testobj);
            service.Delete(testobj);

            var resultafter = await service.GetAll();
            int countafter = resultafter.Count();

            Assert.Equal(countbefore, countafter);
        }
        [Fact]
        public async void testUpdate()
        {
            Program.ConfigureServices();
            CustomerService service = new CustomerService();
            var resultbefore = await service.GetAll();
            int countbefore = resultbefore.Count();

            CustomerModel testobj = new CustomerModel() { FullName = "قادر ره ش" };
            service.Add(testobj);
            var cus = await service.GetFirstOrDefaultFully(4);
          
            cus.FullName = "changed";
            service.Update(cus);

            var cusAfterUpdate = await service.GetFirstOrDefaultFully(4);


            Assert.False(cus.FullName != cusAfterUpdate.FullName);

           
        }
    }
}
