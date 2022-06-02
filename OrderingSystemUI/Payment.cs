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
    public partial class Payment : Form
    {
        public Bill bill;
        public Payment()
        {

            InitializeComponent();
        }

        private void OrderingSystem_Load(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }
        private void showPanel(string panelName)
        {
            if (panelName == "Take Order")
            {
                pnlTakeOrder.Show();
                pnlPayment.Show();
            } 
            else if (panelName == "Bill view")
            {
                //pnlDashboard.Hide();
                //pnlTableView.Hide();
                pnlTakeOrder.Show();
                pnlPayment.Show();
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



        private void btnPayment_Click(object sender, EventArgs e)
        {
            // pnlDashboard.Hide();
            // pnlTableView.Hide();
            pnlTakeOrder.Show();
            pnlPayment.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxTotal.Text != null)
            {
                btnSaveTotal.Enabled = true;
            }
            else
            {
                btnSaveTotal.Enabled = false;
            }
        }

        private void btnSaveTotal_Click(object sender, EventArgs e)
        {
            // determine if valid update
            if (bill != null)
            {
                float desiredTotal = float.Parse(txtBoxTotal.Text);
                if (desiredTotal > bill.BillTotalWithoutTip)
                {
                    float updatedTip = desiredTotal - bill.BillTotalWithoutTip;
                    bill.Tip = updatedTip;
                    // display  tip amount
                    labelDisplayTip.Text = updatedTip.ToString();
                    // display total with tip 
                    labelDisplayTotalWithTip.Text = desiredTotal.ToString();
                } else
                {
                    MessageBox.Show("Please enter a desired amount greater than the Bill total without Tip :)");
                }
            } else
            {
                MessageBox.Show("Please search for a bill first!");
            }
            
        }

        private void btnSearchTable_Click(object sender, EventArgs e)
        {
            if (txtBoxTableNumber.Text != null)
            {
                bill = new Bill();
                int tableID = int.Parse(txtBoxTableNumber.Text);
                OrderService orderService = new OrderService();
                OrderedItemService orderedItemService = new OrderedItemService();
                ItemService itemService = new ItemService();

                List<Order> orders = orderService.GetOrdersByTable(tableID);
                List<OrderedItem> orderedItems = new List<OrderedItem>(); // use this list
                foreach (Order order in orders)
                {
                    orderedItems.Concat(orderedItemService.GetOrderedItemsByOrder(order.OrderId));
                }
                foreach(OrderedItem orderedItem in orderedItems)
                {
                    orderedItem.item = itemService.GetItem(orderedItem.itemID);
                }
                bill.OrderedItems = orderedItems;
                // Display the ordered items associated with the bill 
                DisplayOrderedItems(orderedItems);

            }
        }

        public void DisplayOrderedItems(List<OrderedItem> orderedItems)
        {
            try
            {
                listViewDisplaybillItems.Items.Clear();

                foreach (OrderedItem orderedItem in orderedItems)
                {
                    ListViewItem li = new ListViewItem(orderedItem.item.ItemName);
                    li.SubItems.Add(orderedItem.amount.ToString());
                    li.SubItems.Add(orderedItem.TotalPriceItem.ToString());
                    li.SubItems.Add(orderedItem.VatAmount.ToString());
                    li.SubItems.Add((orderedItem.TotalPriceItem + orderedItem.VatAmount).ToString());

                    li.Tag = orderedItem;

                    listViewDisplaybillItems.Items.Add(li);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Something went wrong : " + exp.Message);
            }
        }

        private void buttCredit_Click(object sender, EventArgs e)
        {
            if (bill != null)
            {
                bill.PaymentType = PaymentType.creditCard;
                MessageBox.Show("Credit card payment option approved.");
            }
            else
            {
                MessageBox.Show("Please search for a bill first!");
            }
            
        }

        private void buttDebit_Click(object sender, EventArgs e)
        {
            if (bill != null)
            {
                bill.PaymentType = PaymentType.debitCard;
                MessageBox.Show("Debit card payment option approved.");
            }
            else
            {
                MessageBox.Show("Please search for a bill first!");
            }
        }

        private void buttCash_Click(object sender, EventArgs e)
        {
            if (bill != null)
            {
                bill.PaymentType = PaymentType.cash;
                MessageBox.Show("Cash payment option approved.");
            }
            else
            {
                MessageBox.Show("Please search for a bill first!");
            }
        }
    }
}
