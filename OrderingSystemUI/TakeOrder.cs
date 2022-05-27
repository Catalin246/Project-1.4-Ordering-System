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
            //showPanel("Take Order");
        }

        private void tableViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            TableView tableView = new TableView();
            tableView.Show();
        }
        //private void showPanel(string panelName)
        //{
        //    if (panelName == "Take Order")
        //    {
        //        pnlTakeOrder.Show();
        //    }
        //}

        //private void tableViewToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    showPanel("Take OrderS");
        //}

        //Create an order

        Order order;

        //Display items
        public void DisplayItems(List<Item> items)
        {
            try
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
            catch (Exception exp)
            {
                MessageBox.Show("Something went wrong : " + exp.Message);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            try
            {
                order.items = null;

                listViewOrderItems.Items.Clear();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Something went wrong : " + exp.Message);
            }
        }

        private void btnMinus_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool contains = false;

                if (listViewMenuItems.SelectedItems.Count == 0)
                    return;

                ListViewItem selectedItem = listViewOrderItems.SelectedItems[0];
                OrderedItem itemSelected = (OrderedItem)selectedItem.Tag;

                foreach (OrderedItem item in order.items)
                {
                    if (itemSelected == item)
                        if (item.amount == 1)
                            contains = true;
                        else
                            item.amount--;
                }

                if (contains)
                    order.items.Remove(itemSelected);

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
            catch (Exception exp)
            {
                MessageBox.Show("Something went wrong : " + exp.Message);
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
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
            catch (Exception exp)
            {
                MessageBox.Show("Something went wrong : " + exp.Message);
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
                MessageBox.Show("Something went wrong : " + exp.Message);
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
                MessageBox.Show("Something went wrong : " + exp.Message);
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
                MessageBox.Show("Something went wrong : " + exp.Message);
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
                MessageBox.Show("Something went wrong : " + exp.Message);
            }
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception exp)
            {
                MessageBox.Show("Something went wrong : " + exp.Message);
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {

            try
            {
                this.Close();
                Payment payment = new Payment();
                payment.Show();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Something went wrong : " + exp.Message);
            }
        }
    }
}
