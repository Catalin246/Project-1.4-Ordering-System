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
    public partial class TableView : Form
    {
        private int number;
        public TableView()
        {
            InitializeComponent();
        }
        private void tableViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("TableView");
        }

        private void pnlOrderView_Paint(object sender, PaintEventArgs e)
        {

        }
        private void showPanel(string panelName)
        {
            if (panelName == "TableView")
            {
                pnlTableView.Show();
                //new Payment().Show();
            }
        }
        public void ChangeColor(int number, string btnInput)
        {
            string name = $"Table {number.ToString()}";
            List<Button> buttons = this.Controls.OfType<Button>().ToList();
            for (int i = 0; i < buttons.Count; i++)
            {
                if (buttons[i].Text == name)
                {
                    switch (btnInput.ToLower())
                    {
                        case "sit":
                            buttons[i].BackColor = Color.Red;
                            break;
                        default:
                            buttons[i].BackColor = Color.Transparent;
                            break;
                    }
                }
            }
        }
        private void CallPnlOptions(int number)
        {
            
            TableViewOptions options = new TableViewOptions(number,this);
            options.Show();
        }

        private void btnTable01_Click(object sender, EventArgs e)
        {
            CallPnlOptions(1);
        }

        private void btnTable02_Click(object sender, EventArgs e)
        {
            CallPnlOptions(2);
        }

        private void btnTable03_Click(object sender, EventArgs e)
        {
            CallPnlOptions(3);
        }

        private void btnTable04_Click(object sender, EventArgs e)
        {
            CallPnlOptions(4);
        }

        private void btnTable05_Click(object sender, EventArgs e)
        {
            CallPnlOptions(5);
        }

        private void btnTable06_Click(object sender, EventArgs e)
        {
            CallPnlOptions(6);
        }

        private void btnTable07_Click(object sender, EventArgs e)
        {
            CallPnlOptions(7);
        }

        private void btnTable08_Click(object sender, EventArgs e)
        {
            CallPnlOptions(8);
        }

        private void btnTable09_Click(object sender, EventArgs e)
        {
            CallPnlOptions(9);
        }

        private void btnTable010_Click(object sender, EventArgs e)
        {
            CallPnlOptions(10); ;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnSeatingACustomer_Click(object sender, EventArgs e)
        {
                     
        }        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCanselSeating_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            KitchenView kitchenViewForm = new KitchenView();
            kitchenViewForm.Show();
        }
    }
}
