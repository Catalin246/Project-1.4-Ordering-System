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
            string query = "SELECT [Employee_Name],[Employee_Password] FROM Employee";
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
                };

                account.Add(accounts);
            }
            return account;
        }
    }
}
