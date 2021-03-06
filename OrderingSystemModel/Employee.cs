using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystemModel
{
    public class Employee
    {
        public Employee() { }
        public Employee(string name, string role)
        {
            EmployeeName = name;
            EmployeeRole = role;
        }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePassword { get; set; }
        public string salt { get; set; }
        public string EmployeeRole { get; set; }
    }
}