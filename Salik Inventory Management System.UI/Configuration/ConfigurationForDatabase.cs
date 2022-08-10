using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salik_Inventory_Management_System.UI.Configuration
{
    public class ConfigurationForDatabase
    {
        IConfiguration configuration;

        public ConfigurationForDatabase()
        {
            configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();
        }
    }
}
