using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OrderingSystemModel;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Collections.ObjectModel;

namespace OrderingSystemDAL
{

    public class BillDAO : BaseDao
    {
        public List<Bill> GetAllBills()
        {
            string query = "SELECT studentId, studentFirstName, studentLastName  FROM [Students]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Bill> ReadTables(DataTable dataTable)
        {
            List<Bill> bills = new List<Bill>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Bill bill = new Bill()
                {
                    BillId = (int)dr["billId"],
                    BillNote = (string)(dr["billNotes"]),
                    PaymentType = (string)(dr["paymentType"])
                };
                bills.Add(bill);
            }
            return bills;
        }
    
    }
}
