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
        public Option(string employeeName, string employeeRole)
        {
            InitializeComponent();
            this.employeeName = employeeName;
            this.employeeRole = employeeRole;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void Option_Load(object sender, EventArgs e)
        {
            lblEmployeeName.Text = employeeName;
            lblEmployeeRole.Text = employeeRole;
        }
    }
}
