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
        OrderService orderService = new OrderService();
        OrderedItemService orderedItemService = new OrderedItemService();
        ItemService itemService = new ItemService();
        BillService billService = new BillService();
        public Bill bill;
        public TableView tableView;
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
            this.Hide();
            tableView.Show();
        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            showPanel("Take Order");
        }



        private void btnPayment_Click(object sender, EventArgs e)
        {
            pnlPayment.Show();
        }

        private void btnSearchTable_Click(object sender, EventArgs e)
        {
            int parsedValue;
            try
            {
                if (txtBoxTableNumber.Text != null)
                {
                    if (int.TryParse(txtBoxTableNumber.Text, out parsedValue))
                    {
                        this.setBillByTable(parsedValue); //returns a list of all ordered items related to that table }
                    }
                    else { MessageBox.Show("Please insert a number"); }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
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
           
                if (checkBoxSplitBill.Checked)
                {
                    float splitAmong = float.Parse(comboBoxSplitBill.GetItemText(comboBoxSplitBill.SelectedItem));
                    for (int i = 0; i < splitAmong; i++) //creates different bill for each of them
                    {
                        billService.CloseBill(this.bill, splitAmong);
                    }
                    
                }
                else
                {
                    billService.CloseBill(this.bill, 1); //closes the bill and stores all the items in the database in that specific bill
                }
                MessageBox.Show($"{comboBoxPaymentType.GetItemText(comboBoxPaymentType.SelectedItem)} was successful! Thank you!");

                orderService.MarkOrdersPaid(bill.tableId); //updates all orders related to that table to paid in the database
                foreach (Order order in bill.Orders)
                { 
                    orderedItemService.ChangeOrderStatusToPaid(order.OrderId); //updates the ordered Items from those orders to
                                                                               //paid in the database
                }
                TableService tableService = new TableService();
                tableService.OpenTable(bill.tableId); //set table to available
                tableView.ChangeColor(bill.tableId, "");
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

        private void setBillByTable(int tableID) //creates the list of ordered products of the bill and displays it in a list view in bill
        {
            bill = new Bill();
            bill.tableId = tableID;
        
            List<Item> allDrinks = itemService.GetDrinks(); //gets all drinks and its type 

            bill.Orders = orderService.GetOrdersByTable(tableID);
 
            List<OrderedItem> orderedItems = new List<OrderedItem>(); // combine all the ordered items from various orders placed on the same table
            foreach (Order order in bill.Orders ) //get all the orders from the bill and then gets all the items in the order
                                                  //and combine it into the ordered itmes list
            {
                orderedItems.AddRange(orderedItemService.GetOrderedItemsByOrder(order.OrderId));//add a new list to an existing one
            }
            // NICE TO DO, create query to select all associated ordered items in one call
            // get all the open ordered items (non closed) 
            bool isDrink = false;
            /* Checks each Ordered  item to see if it is a drink
             * If it is, we set the item of the ordered item to the drink. that way we can diffrentiate the vat price
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
                    orderedItem.Item = itemService.GetItem(orderedItem.ItemID); //gets all the inf about the item to be able to display it later on
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
            BttUpdateTotal.Enabled = true;
            buttFinalizePayment.Enabled = true;
        }


        private void cleanPaymentView() 
        {
            listViewDisplaybillItems.Clear();
            checkBoxSplitBill.Checked = false;
            comboBoxSplitBill.Enabled = false;
            comboBoxPaymentType.SelectedIndex = 0;
            BttUpdateTotal.Enabled = true;
            buttFinalizePayment.Enabled = true;
            labelDisplayTotalWithTip.Text = "";
            labelDisplayTip.Text = "0,00";
            txtBoxTotal.Text = "";
            lblTotalWithVatValue.Text = "";
            lblTotalWithVatValue.Visible = false;
            lblTotalWithVat.Visible = false;
            txtBoxTableNumber.Text = "";
            txtBoxFeedBack.Text = "";
        }

        private void BttUpdateTotal_Click_1(object sender, EventArgs e)
        {
            // determine if valid update
            float desiredTotal;
            if (float.TryParse(txtBoxTotal.Text, out desiredTotal))
            {
                if (bill != null)
                {
                    if (desiredTotal > bill.BillTotalWithoutTip)
                    {
                        float updatedTip = desiredTotal - bill.BillTotalWithoutTip;
                        bill.Tip = updatedTip;
                        // display  tip amount
                        labelDisplayTip.Text = updatedTip.ToString("0.00");
                        // display total with tip 
                        labelDisplayTotalWithTip.Text = desiredTotal.ToString("0.00");
                    }
                    else
                    {
                        MessageBox.Show("Please enter a desired amount greater than the Bill total without Tip :)");
                    }
                }
                else
                {
                    MessageBox.Show("Please search for a bill first!");
                }
            } else
            {
                MessageBox.Show("Please enter a valid total amount.");
            }

        }

        private void txtBoxTotal_TextChanged_1(object sender, EventArgs e)
        {
            {
                if (txtBoxTotal.Text != null)
                {
                    BttUpdateTotal.Enabled = true;
                }
                else
                {
                    BttUpdateTotal.Enabled = false;
                }
            }
        }
    }
}
