using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Model;

namespace WebAPI.Repository
{
    public interface IRepo
    {
        void AddEmployee(Employee employee);
        IEnumerable<Employee> GetDetails();
    }
}
