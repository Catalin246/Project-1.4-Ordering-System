using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderingSystemUI;
using OrderingSystemLogic;
using OrderingSystemModel;

namespace OrderingSystemUI
{
    public partial class TableViewOptions : Form
    {
        private TableView tableView;
        private TakeOrder takeOrder;
        private int tableNumber;
        public TableViewOptions(int tableNumber, TableView tableView,TakeOrder takeOrder)
        {
            this.takeOrder = takeOrder; 
            this.tableNumber = tableNumber;
            this.tableView = tableView;
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //Show take order form (catalin;)))  
            ACustomerIsSitting(tableNumber, "ordered");
            TableService tableService = new TableService();
            tableService.Order(tableNumber);
            tableView.Hide();
            takeOrder.tableView = tableView;
            takeOrder.Show();
        }

        private void btnSeatingACustomer_Click(object sender, EventArgs e)
        {
            ACustomerIsSitting(tableNumber, "sit"); 
            TableService tableService = new TableService();
        }

        private void btnCanselSeating_Click(object sender, EventArgs e)
        {
            tableView.ChangeColor(tableNumber, "Cancel");
            TableService tableService = new TableService();
            this.Hide();
            tableService.CancelSit(tableNumber);
        }
        private void ACustomerIsSitting(int tableNumber, string input)
        {
            tableView.ChangeColor(tableNumber, input); 
            TableService tableService = new TableService();
            this.Hide();
            tableService.Sit(tableNumber);
        }
    }
}
