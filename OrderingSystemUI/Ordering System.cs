using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderingSystemDAL;
using OrderingSystemLogic;
using OrderingSystemModel;

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
                pnlTakeOrder.Hide();
                pnlTableView.Hide();
                pnlDashboard.Show();
            }
            else if(panelName == "Table view")
            {
                pnlTakeOrder.Hide();
                pnlDashboard.Hide();
                pnlTableView.Show();
            }
            else if (panelName == "Take Order")
            {
                pnlDashboard.Hide();
                pnlTableView.Hide();
                pnlTakeOrder.Show();
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
            showPanel("Take Order");
        }

        //Take order
        private void btnDrinks_Click(object sender, EventArgs e)
        {
            try
            {
                DrinkService drinkService = new DrinkService(); 
                List<Drink> drinks = drinkService.GetDrinks(); 

                
                listViewMenuItems.Items.Clear();

                foreach (Drink drink in drinks)
                {
                    ListViewItem li = new ListViewItem(drink.DrinkId.ToString());
                    li.SubItems.Add(drink.DrinkName);
                    li.SubItems.Add(drink.DrinkPrice.ToString());
                   
                    li.Tag = drink;

                    listViewMenuItems.Items.Add(li);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Something went wrong while loading the drinks : " + exp.Message);
            }
        }
        private void btnStarters_Click(object sender, EventArgs e)
        {

        }

        private void btnMains_Click(object sender, EventArgs e)
        {

        }

        private void btnDesserts_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        //Payment

        private void btnPayment_Click(object sender, EventArgs e)
        {
            pnlDashboard.Hide();
            pnlTableView.Hide();
            pnlTakeOrder.Hide();
            pnlPayment.Show();
        }

        private void pnlPayment_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listViewOrderItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
