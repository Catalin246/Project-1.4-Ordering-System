using OrderingSystemDAL;
using OrderingSystemModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystemLogic
{
    public class TableService
    {
        TableDao tabledb;
        public TableService()
        {
            tabledb = new TableDao();
        }
        public List<Table> GetTable()
        {
            List<Table> tables = tabledb.GetAllTable();
            return tables;
        }
        public void Served(Table selectedOrder)
        {
            tabledb.Served(selectedOrder);
        }
    }
}
