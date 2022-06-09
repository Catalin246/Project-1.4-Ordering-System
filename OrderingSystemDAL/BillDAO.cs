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
        public Order order;
        private readonly SqlConnection dbConnection;//my sql connection object

        public BillDAO()
        {
            string connString = ConfigurationManager
                .ConnectionStrings["2122chapeau.database.windows.net"]
                .ConnectionString;

            dbConnection = new SqlConnection(connString);//passing my database to my sql object
        }
        public List<Bill> GetAllBills()
        {
            string query = "SELECT studentId, studentFirstName, studentLastName  FROM dbo.Bill";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Bill> GetOpenBills(int tableID)
        {
            string query = "SELECT BillID from dbo.Bill WHERE TableId = @tableID and ClosedBill = 0 ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Bill> ReadTables(DataTable dataTable)
        {
            List<Bill> bills = new List<Bill>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Bill bill = new Bill()
                {
                    BillId = (int)dr["billId"],
                    BillFeedback = (string)(dr["billFeedback"]),
                    PaymentType = (PaymentType)(dr["paymentType"]),
                    tableId = (int)dr["tableId"],
                };
                bills.Add(bill);
            }
            return bills;
        }

        public void CloseBill(Bill bill, float splitAmong = 1)
        {
            string query = "INSERT INTO dbo.Bill VALUES(@PaymentType, @BillFeedback, @BillTotal, @Tip, @TableID, 1)";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            sqlParameters[0] = new SqlParameter("@PaymentType", bill.PaymentType.ToString());
            sqlParameters[1] = new SqlParameter("@BillFeedback", bill.BillFeedback);
            sqlParameters[2] = new SqlParameter("@BillTotal", Decimal.Round((decimal)(bill.BillTotalWithoutTip / splitAmong), 2));
            sqlParameters[3] = new SqlParameter("@Tip", Decimal.Round((decimal)(bill.Tip / splitAmong), 2));
            sqlParameters[4] = new SqlParameter("@TableID", bill.tableId);
            ExecuteSelectQuery(query, sqlParameters);
        }

        /*public Bill GetBillByTable(int tableId)
        {
            
            SqlCommand command = new SqlCommand("SELECT * FROM Table WHERE TableId = @tableId");
            command.Parameters.AddWithValue("@TableId", tableId);//@Id is a sql parameter that will be filled with your customerId variable
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                order = ReadTable(reader);//
            }
            reader.Close();
            dbConnection.Close();
            return order;
        }*/

    }
}
