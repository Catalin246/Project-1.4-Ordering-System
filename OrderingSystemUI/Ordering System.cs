using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingSystemUI
{
    public partial class OrderingSystem : Form
    {
        public OrderingSystem()
        {
            InitializeComponent();
        }

        private void OrderingSystem_Load(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }
        private void showPanel(string panelName)
        {

            if (panelName == "Dashboard")
            {
                pnlTableView.Hide();
                pnlDashboard.Show();
            }
            else if(panelName == "Table view")
            {
                pnlDashboard.Hide();
                pnlTableView.Show();
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void barViewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kitchenViewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tableViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Table view");
        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            TakeOrder takeOrder = new TakeOrder();
            takeOrder.Show();
        }
    }
}
