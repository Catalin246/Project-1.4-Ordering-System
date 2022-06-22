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
        public Employee GetUserNameAndPasscode(string name,string passcode)
        {
            Employee employeeLogin = employeedb.GetEmployeeNameAndPassc(name, PasswordHasher.Base64Encode(passcode));
            return employeeLogin;
        }
        public bool PasswordIscorrect(string password,Employee employee)
        {
            return (PasswordHasher.Base64Encode(password) == employee.EmployeePassword);
        }        
    }
}