using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingSystemUI
{
    public partial class AddNote : Form
    {
        
        TakeOrder takeOrder;
        ListViewItem selectedItem;
        public AddNote(TakeOrder takeOrder, ListViewItem selectedItem)
        {
            InitializeComponent();
            this.takeOrder = takeOrder;
            this.selectedItem = selectedItem;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                takeOrder.note = txtAddNote.Text;
                this.Close();

                takeOrder.DisplayOrderItemsNote(takeOrder.order.items, takeOrder.note, selectedItem);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Something went wrong : " + exp.Message);
            }
        }
    }
}
