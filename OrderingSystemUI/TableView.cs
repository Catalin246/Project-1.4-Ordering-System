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
                // pnlTableView.Show();
                new Payment().Show();
            }
        }
        public void ChangeColor(int number)
        {
            string name = $"Table {number.ToString()}";
            List<Button> buttons = this.Controls.OfType<Button>().ToList();
            for (int i = 0; i < buttons.Count; i++)
            {
                if (buttons[i].Text == name)
                {
                    buttons[i].BackColor = Color.Red;
                }
                //}

                //foreach (var button in this.Controls.OfType<Button>())
                //{
                //    if (button.Text == name)
                //        button.BackColor = Color.Red;
                //    else
                //        button.BackColor = Color.Green;
                //
            }
        }
        private void CallPnlOptions(int number)
        {
            TableViewOptions options = new TableViewOptions(number,this);
            options.ShowDialog();
        }

        private void btnTable01_Click(object sender, EventArgs e)
        {
            //this.Close(); // close the form
            showPanel("pnlTableOptions");
            CallPnlOptions(1);
        }

        private void btnTable02_Click(object sender, EventArgs e)
        {
            showPanel("pnlTableOptions");
            number = 2;
        }

        private void btnTable03_Click(object sender, EventArgs e)
        {
            showPanel("pnlTableOptions");
            number = 3;
        }

        private void btnTable04_Click(object sender, EventArgs e)
        {
            showPanel("pnlTableOptions");
            number = 4;
        }

        private void btnTable05_Click(object sender, EventArgs e)
        {
            showPanel("pnlTableOptions");
            number = 5;
        }

        private void btnTable06_Click(object sender, EventArgs e)
        {
            showPanel("pnlTableOptions");
            number = 6;
        }

        private void btnTable07_Click(object sender, EventArgs e)
        {
            showPanel("pnlTableOptions");
            number = 7;
        }

        private void btnTable08_Click(object sender, EventArgs e)
        {
            showPanel("pnlTableOptions");
            number = 8;
        }

        private void btnTable09_Click(object sender, EventArgs e)
        {
            showPanel("pnlTableOptions");
            number = 9;
        }

        private void btnTable010_Click(object sender, EventArgs e)
        {
            showPanel("pnlTableOptions");
            number = 10;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            showPanel("Take Order");
        }

        private void btnSeatingACustomer_Click(object sender, EventArgs e)
        {
            ChangeColor(number);
            
        }        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCanselSeating_Click(object sender, EventArgs e)
        {
            //ResetColor(number);
        }
    }
}
