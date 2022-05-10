
namespace OrderingSystemUI
{
    partial class OrderingSystem
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitchenViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.pnlTableView = new System.Windows.Forms.Panel();
            this.btnTable1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pnlTableView.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.barViewToolStripMenuItem,
            this.kitchenViewToolStripMenuItem,
            this.tableViewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // barViewToolStripMenuItem
            // 
            this.barViewToolStripMenuItem.Name = "barViewToolStripMenuItem";
            this.barViewToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.barViewToolStripMenuItem.Text = "Bar view";
            this.barViewToolStripMenuItem.Click += new System.EventHandler(this.barViewToolStripMenuItem_Click);
            // 
            // kitchenViewToolStripMenuItem
            // 
            this.kitchenViewToolStripMenuItem.Name = "kitchenViewToolStripMenuItem";
            this.kitchenViewToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.kitchenViewToolStripMenuItem.Text = "Kitchen view";
            this.kitchenViewToolStripMenuItem.Click += new System.EventHandler(this.kitchenViewToolStripMenuItem_Click);
            // 
            // tableViewToolStripMenuItem
            // 
            this.tableViewToolStripMenuItem.Name = "tableViewToolStripMenuItem";
            this.tableViewToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.tableViewToolStripMenuItem.Text = "Table view";
            this.tableViewToolStripMenuItem.Click += new System.EventHandler(this.tableViewToolStripMenuItem_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Location = new System.Drawing.Point(12, 27);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(776, 411);
            this.pnlDashboard.TabIndex = 1;
            // 
            // pnlTableView
            // 
            this.pnlTableView.Controls.Add(this.btnTable1);
            this.pnlTableView.Location = new System.Drawing.Point(12, 27);
            this.pnlTableView.Name = "pnlTableView";
            this.pnlTableView.Size = new System.Drawing.Size(776, 411);
            this.pnlTableView.TabIndex = 2;
            // 
            // btnTable1
            // 
            this.btnTable1.Location = new System.Drawing.Point(26, 21);
            this.btnTable1.Name = "btnTable1";
            this.btnTable1.Size = new System.Drawing.Size(75, 64);
            this.btnTable1.TabIndex = 0;
            this.btnTable1.Text = "Table 1";
            this.btnTable1.UseVisualStyleBackColor = true;
            this.btnTable1.Click += new System.EventHandler(this.btnTable1_Click);
            // 
            // OrderingSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlTableView);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderingSystem";
            this.Text = "Ordering System";
            this.Load += new System.EventHandler(this.OrderingSystem_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlTableView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitchenViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableViewToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Panel pnlTableView;
        private System.Windows.Forms.Button btnTable1;
    }
}

