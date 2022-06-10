using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderingSystemDAL;
using OrderingSystemModel;

namespace OrderingSystemLogic
{
    public class EmployeeService
    {
        EmployeeDao employeedb;
        public EmployeeService()
        {
            employeedb = new EmployeeDao();
        }

        public List<Employee> GetAllEmployee()
        {
            List<Employee> employees = employeedb.GetAllEmployee();
            return employees;
        }
    }
}