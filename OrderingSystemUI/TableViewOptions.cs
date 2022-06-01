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

namespace OrderingSystemUI
{
    public partial class TableViewOptions : Form
    {
        private TableView tableView;
        private int number;
        public TableViewOptions(int number, TableView tableView)
        {
            this.number = number;
            this.tableView = tableView;
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //showPanel("Take Order");
            //Show take order form (catalin;)))  
            ACustomerIsSitting(number, "sit");

            this.Hide();
            TakeOrder takeOrder = new TakeOrder(number);
            takeOrder.Show();
        }

        private void btnSeatingACustomer_Click(object sender, EventArgs e)
        {
            ACustomerIsSitting(number, "sit");
        }

        private void btnCanselSeating_Click(object sender, EventArgs e)
        {
            tableView.ChangeColor(number, "Cancel");
        }
        private void ACustomerIsSitting(int number, string sit)
        {

            tableView.ChangeColor(number, "Sit");
        }
    }
}
