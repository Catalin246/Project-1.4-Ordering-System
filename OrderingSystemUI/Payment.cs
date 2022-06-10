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
            lblTotalWithVat.Hide();
            lblTotalWithVatValue.Hide();
        }

        public Payment (int tableID)
        {
            InitializeComponent();
            comboBoxPaymentType.SelectedIndex = 0;
            comboBoxSplitBill.SelectedIndex = 0;
            this.setBillByTable(tableID);
 
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
            showPanel("Bar view");
        }

        private void kitchenViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Kitchen view");
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
                    labelDisplayTip.Text = updatedTip.ToString("0.00");
                    // display total with tip 
                    labelDisplayTotalWithTip.Text = desiredTotal.ToString("0.00");
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
                this.cleanPaymentView();
                
                this.setBillByTable(int.Parse(txtBoxTableNumber.Text));
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
                    li.SubItems.Add(orderedItem.VatAmount.ToString("0.00"));
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


        private void buttFinalizePayment_Click(object sender, EventArgs e)
        {
            if (bill != null)
            {
                setPaymentType();
                if (checkBoxSplitBill.Checked && comboBoxSplitBill.SelectedIndex == 0)
                {
                    MessageBox.Show("Please select a valid number from the dropdown.");
                    return;
                }
                BillService billService = new BillService();
                if (checkBoxSplitBill.Checked)
                {
                    float splitAmong = float.Parse(comboBoxSplitBill.GetItemText(comboBoxSplitBill.SelectedItem));
                    for (int i = 0; i < splitAmong; i++)
                    {
                        billService.CloseBill(this.bill, splitAmong);
                    }
                    
                }
                else
                {
                    billService.CloseBill(this.bill, 1);
                }
                MessageBox.Show($"{comboBoxPaymentType.GetItemText(comboBoxPaymentType.SelectedItem)} was successful! Thank you!");
                OrderService orderService = new OrderService();
                OrderedItemService orderedItemService = new OrderedItemService();

                orderService.MarkOrdersPaid(bill.tableId);
                foreach (Order order in bill.Orders)
                {
                    orderedItemService.ChangeOrderStatusToPaid(order.OrderId);
                }

                this.cleanPaymentView();
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
                    MessageBox.Show($"Feedback has been added. Thanks!");
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

        private void txtBoxFeedBack_TextChanged(object sender, EventArgs e)
        {
            if(txtBoxFeedBack.Text != null)
            {
                bttAddFeedBack.Enabled = true;
            }
        }

        private void checkBoxSplitBill_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxSplitBill.Checked)
            {
                comboBoxSplitBill.Enabled = true;
            } else
            {
                comboBoxSplitBill.Enabled = false;
            }
        }

        private void setBillByTable(int tableID)
        {
            bill = new Bill();
            bill.tableId = tableID;
            OrderService orderService = new OrderService();
            OrderedItemService orderedItemService = new OrderedItemService();
            ItemService itemService = new ItemService();
            List<Item> allDrinks = itemService.GetDrinks();

            bill.Orders = orderService.GetOrdersByTable(tableID);
 
            List<OrderedItem> orderedItems = new List<OrderedItem>(); // use this list
                                                                      // combine all the ordered items from various orders
            foreach (Order order in bill.Orders )
            {
                orderedItems.AddRange(orderedItemService.GetOrderedItemsByOrder(order.OrderId));
            }
            // NICE TO DO, create query to select all associated ordered items in one call
            // get all the open ordered items (non closed) 
            bool isDrink = false;
            /* Checks each item to see if it is a drink
             * If it is, we set the item of the ordered item to the drink
             * If it is not a drink, we query the database for the food item
             */
            foreach (OrderedItem orderedItem in orderedItems)
            {
                foreach (Item drink in allDrinks)
                {
                    if (drink.ItemId == orderedItem.ItemID)
                    {
                        orderedItem.Item = drink;
                        isDrink = true;
                        break;
                    }
                }
                if (!isDrink)
                {
                    orderedItem.Item = itemService.GetItem(orderedItem.ItemID);
                }
                isDrink = false;
            }
            bill.OrderedItems = orderedItems;
            // Display the ordered items associated with the bill 
            DisplayOrderedItems(orderedItems);
            lblTotalWithVat.Visible = true;
            lblTotalWithVatValue.Text = bill.BillTotalWithoutTip.ToString("0.00");
            lblTotalWithVatValue.Visible = true;
            labelDisplayTotalWithTip.Text = bill.BillTotalWithoutTip.ToString("0.00");
            checkBoxSplitBill.Enabled = true;
            comboBoxPaymentType.Enabled = true;
            btnSaveTotal.Enabled = true;
            buttFinalizePayment.Enabled = true;
        }


        private void cleanPaymentView()
        {
            listViewDisplaybillItems.Clear();
            checkBoxSplitBill.Checked = false;
            comboBoxSplitBill.Enabled = false;
            comboBoxPaymentType.SelectedIndex = 0;
            btnSaveTotal.Enabled = true;
            buttFinalizePayment.Enabled = true;
            labelDisplayTotalWithTip.Text = "";
            labelDisplayTip.Text = "0,00";
            txtBoxTotal.Text = "";
            lblTotalWithVatValue.Text = "";
            lblTotalWithVatValue.Visible = false;
            lblTotalWithVat.Visible = false;
        }
    }
}
