
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
            this.pnlTakeOrder = new System.Windows.Forms.Panel();
            this.btnModifyOrder = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.btnLunch = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnDiner = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.listViewMenuItems = new System.Windows.Forms.ListView();
            this.ItemID = new System.Windows.Forms.ColumnHeader();
            this.ItemName = new System.Windows.Forms.ColumnHeader();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnTake = new System.Windows.Forms.Button();
            this.listViewOrderItems = new System.Windows.Forms.ListView();
            this.pnlPayment = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.pnlTableView.SuspendLayout();
            this.pnlTakeOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.barViewToolStripMenuItem,
            this.kitchenViewToolStripMenuItem,
            this.tableViewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(914, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // barViewToolStripMenuItem
            // 
            this.barViewToolStripMenuItem.Name = "barViewToolStripMenuItem";
            this.barViewToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.barViewToolStripMenuItem.Text = "Bar view";
            this.barViewToolStripMenuItem.Click += new System.EventHandler(this.barViewToolStripMenuItem_Click);
            // 
            // kitchenViewToolStripMenuItem
            // 
            this.kitchenViewToolStripMenuItem.Name = "kitchenViewToolStripMenuItem";
            this.kitchenViewToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.kitchenViewToolStripMenuItem.Text = "Kitchen view";
            this.kitchenViewToolStripMenuItem.Click += new System.EventHandler(this.kitchenViewToolStripMenuItem_Click);
            // 
            // tableViewToolStripMenuItem
            // 
            this.tableViewToolStripMenuItem.Name = "tableViewToolStripMenuItem";
            this.tableViewToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.tableViewToolStripMenuItem.Text = "Table view";
            this.tableViewToolStripMenuItem.Click += new System.EventHandler(this.tableViewToolStripMenuItem_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Location = new System.Drawing.Point(14, 36);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(887, 548);
            this.pnlDashboard.TabIndex = 1;
            // 
            // pnlTableView
            // 
            this.pnlTableView.Controls.Add(this.btnTable1);
            this.pnlTableView.Location = new System.Drawing.Point(14, 36);
            this.pnlTableView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTableView.Name = "pnlTableView";
            this.pnlTableView.Size = new System.Drawing.Size(887, 548);
            this.pnlTableView.TabIndex = 2;
            // 
            // btnTable1
            // 
            this.btnTable1.Location = new System.Drawing.Point(30, 28);
            this.btnTable1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTable1.Name = "btnTable1";
            this.btnTable1.Size = new System.Drawing.Size(86, 85);
            this.btnTable1.TabIndex = 0;
            this.btnTable1.Text = "Table 1";
            this.btnTable1.UseVisualStyleBackColor = true;
            this.btnTable1.Click += new System.EventHandler(this.btnTable1_Click);
            // 
            // pnlTakeOrder
            // 
            this.pnlTakeOrder.Controls.Add(this.btnModifyOrder);
            this.pnlTakeOrder.Controls.Add(this.btnPayment);
            this.pnlTakeOrder.Controls.Add(this.btnDrinks);
            this.pnlTakeOrder.Controls.Add(this.btnLunch);
            this.pnlTakeOrder.Controls.Add(this.btnAddItem);
            this.pnlTakeOrder.Controls.Add(this.btnDiner);
            this.pnlTakeOrder.Controls.Add(this.button1);
            this.pnlTakeOrder.Controls.Add(this.button2);
            this.pnlTakeOrder.Controls.Add(this.lblMenu);
            this.pnlTakeOrder.Controls.Add(this.lblOrderNumber);
            this.pnlTakeOrder.Controls.Add(this.lblTableNumber);
            this.pnlTakeOrder.Controls.Add(this.listViewMenuItems);
            this.pnlTakeOrder.Controls.Add(this.btnCancel);
            this.pnlTakeOrder.Controls.Add(this.btnTake);
            this.pnlTakeOrder.Controls.Add(this.listViewOrderItems);
            this.pnlTakeOrder.Controls.Add(this.pnlPayment);
            this.pnlTakeOrder.Location = new System.Drawing.Point(15, 36);
            this.pnlTakeOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTakeOrder.Name = "pnlTakeOrder";
            this.pnlTakeOrder.Size = new System.Drawing.Size(887, 548);
            this.pnlTakeOrder.TabIndex = 3;
            // 
            // btnModifyOrder
            // 
            this.btnModifyOrder.BackColor = System.Drawing.Color.Teal;
            this.btnModifyOrder.Location = new System.Drawing.Point(357, 420);
            this.btnModifyOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModifyOrder.Name = "btnModifyOrder";
            this.btnModifyOrder.Size = new System.Drawing.Size(159, 44);
            this.btnModifyOrder.TabIndex = 28;
            this.btnModifyOrder.Text = "Modify Order";
            this.btnModifyOrder.UseVisualStyleBackColor = false;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.Teal;
            this.btnPayment.Location = new System.Drawing.Point(522, 420);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(159, 44);
            this.btnPayment.TabIndex = 27;
            this.btnPayment.Text = "Pay";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnDrinks
            // 
            this.btnDrinks.BackColor = System.Drawing.Color.Teal;
            this.btnDrinks.Location = new System.Drawing.Point(310, 92);
            this.btnDrinks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(130, 44);
            this.btnDrinks.TabIndex = 26;
            this.btnDrinks.Text = "Drinks";
            this.btnDrinks.UseVisualStyleBackColor = false;
            this.btnDrinks.Click += new System.EventHandler(this.btnDrinks_Click);
            // 
            // btnLunch
            // 
            this.btnLunch.BackColor = System.Drawing.Color.Teal;
            this.btnLunch.Location = new System.Drawing.Point(173, 92);
            this.btnLunch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLunch.Name = "btnLunch";
            this.btnLunch.Size = new System.Drawing.Size(130, 44);
            this.btnLunch.TabIndex = 25;
            this.btnLunch.Text = "Lunch";
            this.btnLunch.UseVisualStyleBackColor = false;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.Teal;
            this.btnAddItem.Location = new System.Drawing.Point(195, 420);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(159, 44);
            this.btnAddItem.TabIndex = 24;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            // 
            // btnDiner
            // 
            this.btnDiner.BackColor = System.Drawing.Color.Teal;
            this.btnDiner.Location = new System.Drawing.Point(30, 92);
            this.btnDiner.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDiner.Name = "btnDiner";
            this.btnDiner.Size = new System.Drawing.Size(130, 44);
            this.btnDiner.TabIndex = 16;
            this.btnDiner.Text = "Diner";
            this.btnDiner.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(778, 123);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(2, 0, 0, 1);
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(25, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "- ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(810, 123);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 1);
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(25, 29);
            this.button2.TabIndex = 15;
            this.button2.Text = "+ ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(30, 53);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(46, 20);
            this.lblMenu.TabIndex = 12;
            this.lblMenu.Text = "Menu";
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Location = new System.Drawing.Point(735, 53);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(126, 20);
            this.lblOrderNumber.TabIndex = 11;
            this.lblOrderNumber.Text = "Order No. 001347";
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.AutoSize = true;
            this.lblTableNumber.Location = new System.Drawing.Point(495, 53);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(61, 20);
            this.lblTableNumber.TabIndex = 10;
            this.lblTableNumber.Text = "Table#1";
            // 
            // listViewMenuItems
            // 
            this.listViewMenuItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemID,
            this.ItemName});
            this.listViewMenuItems.HideSelection = false;
            this.listViewMenuItems.Location = new System.Drawing.Point(30, 144);
            this.listViewMenuItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewMenuItems.Name = "listViewMenuItems";
            this.listViewMenuItems.Size = new System.Drawing.Size(410, 239);
            this.listViewMenuItems.TabIndex = 9;
            this.listViewMenuItems.UseCompatibleStateImageBehavior = false;
            this.listViewMenuItems.View = System.Windows.Forms.View.Details;
            // 
            // ItemID
            // 
            this.ItemID.Text = "Item ID";
            // 
            // ItemName
            // 
            this.ItemName.Text = "Name";
            this.ItemName.Width = 100;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(688, 420);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(159, 44);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel order";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnTake
            // 
            this.btnTake.BackColor = System.Drawing.Color.ForestGreen;
            this.btnTake.Location = new System.Drawing.Point(30, 420);
            this.btnTake.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(159, 44);
            this.btnTake.TabIndex = 7;
            this.btnTake.Text = "Take order";
            this.btnTake.UseVisualStyleBackColor = false;
            // 
            // listViewOrderItems
            // 
            this.listViewOrderItems.HideSelection = false;
            this.listViewOrderItems.Location = new System.Drawing.Point(495, 92);
            this.listViewOrderItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewOrderItems.Name = "listViewOrderItems";
            this.listViewOrderItems.Size = new System.Drawing.Size(351, 291);
            this.listViewOrderItems.TabIndex = 6;
            this.listViewOrderItems.UseCompatibleStateImageBehavior = false;
            // 
            // pnlPayment
            // 
            this.pnlPayment.Location = new System.Drawing.Point(0, 0);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(887, 464);
            this.pnlPayment.TabIndex = 29;
            // 
            // OrderingSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.pnlTakeOrder);
            this.Controls.Add(this.pnlTableView);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrderingSystem";
            this.Text = "Ordering System";
            this.Load += new System.EventHandler(this.OrderingSystem_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlTableView.ResumeLayout(false);
            this.pnlTakeOrder.ResumeLayout(false);
            this.pnlTakeOrder.PerformLayout();
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
        private System.Windows.Forms.Panel pnlTakeOrder;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Label lblTableNumber;
        private System.Windows.Forms.ListView listViewMenuItems;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.ListView listViewOrderItems;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Button btnLunch;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnDiner;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnModifyOrder;
        private System.Windows.Forms.ColumnHeader ItemID;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.Panel pnlPayment;
    }
}

