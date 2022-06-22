using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderingSystemModel;

namespace OrderingSystemDAL
{
    public class EmployeeDao : BaseDao
    {
        public List<Employee> GetAllEmployee()
        {
            string query = "SELECT [Employee_Name],[Employee_Password],Employee_Role FROM Employee";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Employee> ReadTables(DataTable dataTable)
        {
            List<Employee> account = new List<Employee>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Employee accounts = new Employee()
                {
                    EmployeeName = (string)dr["Employee_Name"],
                    EmployeePassword = (string)dr["Employee_Password"],
                    EmployeeRole = (string)dr["Employee_Role"],
                };

                account.Add(accounts);
            }
            return account;
        }
        public Employee GetEmployeeNameAndPassc(string employeeName,string employeePasscode)
        {
            string query = $"SELECT Employee_Name,Employee_Password, Employee_Role FROM Employee WHERE Employee_Name = @employeeName and Employee_Password = @employeePasscode";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@employeeName", employeeName);
            sqlParameters[1] = new SqlParameter("@employeePasscode", employeePasscode);
            return GetEmployeeName(ExecuteSelectQuery(query, sqlParameters));
        }
        public Employee GetEmployeeName(DataTable dataTable)
        {
         List<Employee> employeeName = new List<Employee>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Employee accounts = new Employee()
                {
                    EmployeeName = (string)dr["Employee_Name"],
                    EmployeePassword = (string)dr["Employee_Password"],
                    EmployeeRole = (string)dr["Employee_Role"]
                };
                employeeName.Add(accounts);
            }
            return employeeName[0];
        }
    }
}
