using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Service
{
    public class DataService : IDataService
    {
        public string GetConnectionString()
        {
            return "Data Source=DESKTOP-B7P63U7\\SQLEXPRESS;Initial Catalog=TestUser;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
    }
}
