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

        //Create an order

        Order order;
        private void btnDrinks_Click(object sender, EventArgs e)
        {
            try
            {
                ItemService itemService = new ItemService();
                List<Item> items = itemService.GetDrinks();
                DisplayItems(items);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Something went wrong while loading the drinks : " + exp.Message);
            }
        }
        private void btnStarters_Click(object sender, EventArgs e)
        {
            try
            {
                ItemService itemService = new ItemService();
                List<Item> items = itemService.GetStarters();
                DisplayItems(items);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Something went wrong while loading the drinks : " + exp.Message);
            }
        }

        private void btnMains_Click(object sender, EventArgs e)
        {
            try
            {
                ItemService itemService = new ItemService();
                List<Item> items = itemService.GetMains();
                DisplayItems(items);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Something went wrong while loading the drinks : " + exp.Message);
            }
        }

        private void btnDesserts_Click(object sender, EventArgs e)
        {
            try
            {
                ItemService itemService = new ItemService();
                List<Item> items = itemService.GetDesserts();
                DisplayItems(items);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Something went wrong while loading the drinks : " + exp.Message);
            }
        }

        public void DisplayItems(List<Item> items)
        {
            listViewMenuItems.Items.Clear();

            foreach (Item item in items)
            {
                ListViewItem li = new ListViewItem(item.ItemName);
                li.SubItems.Add(item.ItemPrice.ToString());
                li.SubItems.Add(item.ItemCategory);
                li.SubItems.Add(item.ItemAmount.ToString());
                
                li.Tag = item;

                listViewMenuItems.Items.Add(li);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (order == null)
                //order = new Order();

            if (listViewMenuItems.SelectedItems.Count == 0)
            return;

            ListViewItem selectedItem = listViewMenuItems.SelectedItems[0];
            Item itemSelected = (Item)selectedItem.Tag;

            //if (itemSelected.ItemOrdered == null)   
            //    itemSelected.ItemOrdered = 1;

            OrderedItem orderedItem = new OrderedItem(itemSelected,1,"");

            foreach (OrderedItem item in order.items)
            {
                if (item.item == itemSelected)
                    item.amount++;

            }

            //if (orderedItem.amount == 1)
            //    order.items.Add(orderedItem);

            listViewOrderItems.Items.Clear();

            foreach (OrderedItem item in order.items)
            {
                ListViewItem li = new ListViewItem(item.item.ItemName);
                li.SubItems.Add(item.item.ItemPrice.ToString());
                li.SubItems.Add(item.amount.ToString());

                li.Tag = item;

                listViewOrderItems.Items.Add(li);
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            //if (listViewOrderItems.SelectedItems.Count == 0)
            //  return;

            //ListViewItem selectedItem = listViewMenuItems.SelectedItems[0];
            //Item itemSelected = (Item)selectedItem.Tag;
            
            //if (itemSelected.ItemAmount > 1)
            //    itemSelected.ItemAmount--;
            //else
            //    order.items.Remove(itemSelected);

            //listViewOrderItems.Items.Clear();

            //foreach (Item item in order.items)
            //{
            //    ListViewItem li = new ListViewItem(item.ItemName);
            //    li.SubItems.Add(item.ItemPrice.ToString());
            //    li.SubItems.Add(item.ItemAmount.ToString());

            //    li.Tag = item;

            //    listViewOrderItems.Items.Add(li);
            //}
            //itemSelected = null;
        }

        private void btnReserveTable_Click(object sender, EventArgs e)
        {
            btnDrinks.Enabled = true;
            btnDesserts.Enabled = true; 
            btnMains.Enabled = true;    
            btnStarters.Enabled = true; 
            btnCancel.Enabled = true;   
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            order.items = null;

            listViewOrderItems.Items.Clear();
        }
        //Payment
        private void btnPayment_Click(object sender, EventArgs e)
        {
            pnlDashboard.Hide();
            pnlTableView.Hide();
            pnlTakeOrder.Hide();
            pnlPayment.Show();
        }

        private void pnlTakeOrder_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
