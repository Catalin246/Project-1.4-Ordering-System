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
        public List<Employee> GetAllAccounts()
        {
            string query = "SELECT username, [Password] FROM [Employee]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Employee> ReadTables(DataTable dataTable)
        {
            List<Employee> employee = new List<Employee>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Employee employees = new Employee()
                {
                    userName = (string)dr["username"],
                    password = (string)dr["password"],
                };

                employee.Add(employees);
            }
            return employee;
        }
    }
}
