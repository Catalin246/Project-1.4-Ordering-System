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
        private int number;
        public TableViewOptions(int number, TableView tableView,TakeOrder takeOrder)
        {
            this.takeOrder = takeOrder; 
            this.number = number;
            this.tableView = tableView;
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //Show take order form (catalin;)))  
            ACustomerIsSitting(number, "order");
            TableService tableService = new TableService();
            tableService.Order(number);
            tableView.Hide();
            this.Hide();
            takeOrder.tableView = tableView;
            takeOrder.Show();
        }

        private void btnSeatingACustomer_Click(object sender, EventArgs e)
        {
            ACustomerIsSitting(number, "sit"); 
            TableService tableService = new TableService();
            tableService.Sit(number);
        }

        private void btnCanselSeating_Click(object sender, EventArgs e)
        {
            tableView.ChangeColor(number, "Cancel");
            TableService tableService = new TableService();
            tableService.CancelSit(number);
        }
        private void ACustomerIsSitting(int number, string input)
        {
            tableView.ChangeColor(number, input); 
            TableService tableService = new TableService();
            tableService.Sit(number);
        }
    }
}
