
﻿using OrderingSystemDAL;
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
        public List<Table> GetTablesStatus()
        {
            List<Table> tables = tabledb.GetTableStatus();
            return tables;
        }
        public void Served(Table selectedOrder)
        {
            tabledb.Served(selectedOrder);
        }
        public void Sit(int number)
        {
            tabledb.Sit(number);
        }
        public void CancelSit(int number)
        {
            tabledb.CancelSit(number);
        }
    }
}
