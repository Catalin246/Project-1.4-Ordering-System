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
    public partial class Option : Form
    {
        private string employeeName;
        private string employeeRole;
        private TableView tableView;
        public Option(string employeeName, string employeeRole)
        {
            InitializeComponent();
            this.employeeName = employeeName;
            this.employeeRole = employeeRole;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            TableView tableView = new TableView(employeeName,employeeRole);
            tableView.Hide();
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void Option_Load(object sender, EventArgs e)
        {
            labelEmployeName.Text = employeeName;
            labelEmployeRole.Text = employeeRole;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            TableView tableView = new TableView(employeeName, employeeRole);
            tableView.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
