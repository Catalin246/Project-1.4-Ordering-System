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
            string query = "SELECT USERNAME, [PASSWORD] FROM [ACCOUNT]";
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
                    UserName = (string)dr["USERNAME"],
                    Password = (string)dr["PASSWORD"],
                };

                account.Add(accounts);
            }
            return account;
        }
    }
}
