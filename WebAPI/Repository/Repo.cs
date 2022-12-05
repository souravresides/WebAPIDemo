using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Model;
using WebAPI.Service;

namespace WebAPI.Repository
{
    public class Repo : IRepo
    {
        private readonly IDataService dataService;
        public List<Employee> _employeelist;

        public Repo(IDataService dataService)
        {
            _employeelist = new List<Employee>()
            {
                new Employee() { Id = "1" ,Name = "Sourav", Email="souravresides@gmail.com"}
            };
            this.dataService = dataService;
        }
        public Employee AddEmployee(Employee employee)
        {
            employee.Id = _employeelist.Max(e => e.Id) + 1;
            _employeelist.Add(employee);
            return employee;
        }

        public IEnumerable<Employee> GetDetails()
        {
            return _employeelist;
        }
    }
}
