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
    public partial class Feedback : Form
    {
        private Bill bill;
        public Feedback(Bill bill)
        {
            this.bill = bill;
            InitializeComponent();
        }

        private void btnFeedbackDone_Click(object sender, EventArgs e)
        {
            if (txtBoxFeedBack.Text != null)
            {
                bill.BillFeedback = txtBoxFeedBack.Text;
                MessageBox.Show($"Feedback has been added. Thanks!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter feedback first.");
            }
        }
    }
}
