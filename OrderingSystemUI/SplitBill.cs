using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderingSystemModel;

namespace OrderingSystemUI
{
    public partial class SplitBill : Form
    {
        private Bill bill;
        private float remainingTotal;
        private bool finalCustomer; 
        public SplitBill(Bill bill, float remainingTotal, bool finalCustomer, int customer)
        {
            InitializeComponent();
            this.bill = bill;
            this.remainingTotal = remainingTotal;
            comboBoxPaymentType.SelectedIndex = 0;
            comboBoxPaymentType.Enabled = true;
            this.finalCustomer = finalCustomer;
            lblTotalRemainingAmt.Text = remainingTotal.ToString("0.00");
            lblCustomer.Text = "Customer " + customer.ToString();
            if (finalCustomer)
            {
                txtBoxPaymentAmt.Text = remainingTotal.ToString("0.00");
                txtBoxPaymentAmt.Enabled = false;
                bttFinishPayment.Enabled = true;
            } else
            {
                bttFinishPayment.Enabled = false;
            }

        }

        private void bttFinishPayment_Click(object sender, EventArgs e)
        {
            if (txtBoxPaymentAmt.Text != null)
            {
                bill.SplitTotal = float.Parse(txtBoxPaymentAmt.Text);
                bill.SetPaymentType(comboBoxPaymentType.GetItemText(comboBoxPaymentType.SelectedItem));
                this.Close();
            } else
            {
                MessageBox.Show("Please enter a payment amount before continuing"); 
            }
        }

        private void txtBoxPaymentAmt_TextChanged(object sender, EventArgs e)
        {
            float total;
            if (float.TryParse(txtBoxPaymentAmt.Text, out total))
            {
                if (total >= remainingTotal && !finalCustomer)
                {
                    MessageBox.Show("Please enter an amount less than the remaining total");
                } else if (total <= 0 )
                {
                    MessageBox.Show("Please enter an amount greater than 0.");
                }
                else
                {
                    bttFinishPayment.Enabled = true;
                }

            } else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }
    }
}
