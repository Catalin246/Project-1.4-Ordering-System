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
            comboBoxPaymentType.SelectedIndex = 0;
            comboBoxSplitBill.SelectedIndex = 0;
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
                // combine all the ordered items from various orders
                foreach (Order order in orders)
                {
                    orderedItems.AddRange(orderedItemService.GetOrderedItemsByOrder(order.OrderId));
                }
                // NICE TO DO, create query to select all associated ordered items in one call
                // get all the open ordered items (non closed) 
                foreach(OrderedItem orderedItem in orderedItems)
                {
                    orderedItem.Item = itemService.GetItem(orderedItem.ItemID);
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
                    ListViewItem li = new ListViewItem(orderedItem.Item.ItemName);
                    li.SubItems.Add(orderedItem.Amount.ToString());
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
                DialogResult res = MessageBox.Show("Are you sure you want to Finalize Payment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    //call function to delete all orders and all ordered itemsn from the table
                    bill.PaymentType = PaymentType.creditCard;
                    MessageBox.Show("Credit card payment option approved.");
                    //Some task…

                }
                if (res == DialogResult.No)
                {
                    MessageBox.Show("Just in time to change your mind...");
                    //Some task…
                }
            
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

        private void buttFinalizePayment_Click(object sender, EventArgs e)
        {
            if (bill != null)
            {
                setPaymentType();
                if (checkBoxSplitBill.Enabled && comboBoxSplitBill.SelectedIndex == 0)
                {
                    MessageBox.Show("Please select a valid number from the dropdown.");
                    return;
                }
                BillService billService = new BillService();
                if (checkBoxSplitBill.Enabled)
                {
                    float splitAmong = float.Parse(comboBoxSplitBill.GetItemText(comboBoxSplitBill.SelectedItem));
                    // billService.CloseBill(this.bill, splitAmong);
                }
                else
                {
                    // billService.CloseBill(this.bill);
                }
                MessageBox.Show($"{comboBoxPaymentType.GetItemText(comboBoxPaymentType.SelectedItem)} was successful! Thank you!");
                // need to delete or close orders? 
                // clear table and display/reset bill page
            }
            else
            {
                MessageBox.Show("Please search for a bill first!");
            }
        }

    
        private void setPaymentType()
        {
            String paymentOption = comboBoxPaymentType.GetItemText(comboBoxPaymentType.SelectedItem);
            switch (paymentOption)
            {
                case "Credit Card":
                    bill.PaymentType = PaymentType.creditCard;
                    break;
                case "Debit Card":
                    bill.PaymentType = PaymentType.debitCard;
                    break;
                case "Cash":
                    bill.PaymentType = PaymentType.cash;
                    break;
                case "Mixed Payment":
                    bill.PaymentType = PaymentType.mixedPayment;
                    break;
            }
                
        }
    

        private void bttAddFeedBack_Click(object sender, EventArgs e)
        {
            if (bill != null)
            {
                if (txtBoxFeedBack.Text != null)
                {
                    bill.BillFeedback = txtBoxFeedBack.Text;
                }
                else
                {
                    MessageBox.Show("Please enter feedback first.");
                }
            }
            else
            {
                MessageBox.Show("Please search for a bill first!");
            }
        }

    }
}
