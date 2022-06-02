using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderingSystemDAL;
using OrderingSystemModel;

namespace OrderingSystemLogic
{
    public class TableService
    {
        TableDao tabledb;

        public TableService()
        {
            tabledb = new TableDao();
        }
    }
}
