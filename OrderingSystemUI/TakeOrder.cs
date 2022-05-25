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
    public partial class TakeOrder : Form
    {
        public TakeOrder()
        {
            InitializeComponent();
        }
        private void TakeOrder_Load(object sender, EventArgs e)
        {
            showPanel("Take Order");
        }
        private void showPanel(string panelName)
        {
            if (panelName == "Take Order")
            {
                pnlTakeOrder.Show();
            }
        }

        private void tableViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Take OrderS");
        }

        //Create an order

        Order order;

        //Display items
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

        //private void btnReserveTable_Click_1(object sender, EventArgs e)
        //{
        //    btnDrinks.Enabled = true;
        //    btnDesserts.Enabled = true;
        //    btnMains.Enabled = true;
        //    btnStarters.Enabled = true;
        //    btnCancel.Enabled = true;
        //}

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            order.items = null;

            listViewOrderItems.Items.Clear();
        }

        private void btnMinus_Click_1(object sender, EventArgs e)
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

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            bool contains = false;
            if (order == null)
                order = new Order();

            if (listViewMenuItems.SelectedItems.Count == 0)
                return;

            ListViewItem selectedItem = listViewMenuItems.SelectedItems[0];
            Item itemSelected = (Item)selectedItem.Tag;

            OrderedItem orderedItem = new OrderedItem(itemSelected, 1, "");

            foreach (OrderedItem item in order.items)
            {
                if (item.item == itemSelected)
                {
                    item.amount++;
                    contains = true;
                }
            }

            if (!contains)
                order.items.Add(orderedItem);

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

        private void btnDrinks_Click_1(object sender, EventArgs e)
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

        private void btnStarters_Click_1(object sender, EventArgs e)
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

        private void btnMains_Click_1(object sender, EventArgs e)
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

        private void btnDesserts_Click_1(object sender, EventArgs e)
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
    }
}
