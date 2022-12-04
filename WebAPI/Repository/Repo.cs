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

        public Repo(IDataService dataService)
        {
            this.dataService = dataService;
        }
        public void AddEmployee(Employee employee)
        {
            string strConString = dataService.GetConnectionString();
            using (SqlConnection con = new SqlConnection(strConString))
            {
                con.Open();
                string query = "Insert into Users (Name, Email) values(@Name,@Email)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", employee.Name);
                cmd.Parameters.AddWithValue("@Email", employee.Email);
                int i = cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public IEnumerable<Employee> GetDetails()
        {
            List<Employee> lstEmployee = new List<Employee>();
            string strConString = dataService.GetConnectionString();
            using (SqlConnection con = new SqlConnection(strConString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from Users", con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Employee employee = new Employee();
                        employee.Name = Convert.ToString(dr["Name"]);
                        employee.Email = Convert.ToString(dr["Email"]);
                        lstEmployee.Add(employee);
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return lstEmployee;
            }
        }
    }
}
