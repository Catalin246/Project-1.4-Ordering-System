using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderingSystemModel;
using OrderingSystemDAL;

namespace OrderingSystemLogic
{
    public class EmployeeService
    {
        EmployeeDao employeedb;
        public EmployeeService()
        {
            employeedb = new EmployeeDao();
        }
        public List<Employee> GetAccounts()
        {
            List<Employee> employees = employeedb.GetAllAccounts();
            return employees;
        }
    }
}
