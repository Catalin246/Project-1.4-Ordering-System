namespace OrderingSystemUI
{
    partial class TakeOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.listViewOrderItems = new System.Windows.Forms.ListView();
            this.Name_Item = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.Amount = new System.Windows.Forms.ColumnHeader();
            this.Note = new System.Windows.Forms.ColumnHeader();
            this.btnTake = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.listViewMenuItems = new System.Windows.Forms.ListView();
            this.ItemName = new System.Windows.Forms.ColumnHeader();
            this.ItemPrice = new System.Windows.Forms.ColumnHeader();
            this.Type = new System.Windows.Forms.ColumnHeader();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnStarters = new System.Windows.Forms.Button();
            this.btnMains = new System.Windows.Forms.Button();
            this.btnDesserts = new System.Windows.Forms.Button();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTakeOrder = new System.Windows.Forms.Panel();
            this.btnModify = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuBar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuKitchen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTakeOrder.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.AutoSize = true;
            this.lblTableNumber.Location = new System.Drawing.Point(26, 138);
            this.lblTableNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(0, 25);
            this.lblTableNumber.TabIndex = 10;
            // 
            // listViewOrderItems
            // 
            this.listViewOrderItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name_Item,
            this.Price,
            this.Amount,
            this.Note});
            this.listViewOrderItems.FullRowSelect = true;
            this.listViewOrderItems.HideSelection = false;
            this.listViewOrderItems.Location = new System.Drawing.Point(26, 212);
            this.listViewOrderItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewOrderItems.Name = "listViewOrderItems";
            this.listViewOrderItems.Size = new System.Drawing.Size(495, 296);
            this.listViewOrderItems.TabIndex = 6;
            this.listViewOrderItems.UseCompatibleStateImageBehavior = false;
            this.listViewOrderItems.View = System.Windows.Forms.View.Details;
            this.listViewOrderItems.DoubleClick += new System.EventHandler(this.listViewOrderItems_DoubleClick);
            // 
            // Name_Item
            // 
            this.Name_Item.Text = "Item Name";
            this.Name_Item.Width = 150;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 100;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 100;
            // 
            // Note
            // 
            this.Note.Text = "Note";
            // 
            // btnTake
            // 
            this.btnTake.BackColor = System.Drawing.Color.ForestGreen;
            this.btnTake.Enabled = false;
            this.btnTake.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTake.Location = new System.Drawing.Point(26, 525);
            this.btnTake.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(226, 55);
            this.btnTake.TabIndex = 7;
            this.btnTake.Text = "Take order";
            this.btnTake.UseVisualStyleBackColor = false;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Enabled = false;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(854, 525);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(220, 55);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel order";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.ForeColorChanged += new System.EventHandler(this.btnCancel_Click_1);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // listViewMenuItems
            // 
            this.listViewMenuItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemName,
            this.ItemPrice,
            this.Type});
            this.listViewMenuItems.FullRowSelect = true;
            this.listViewMenuItems.HideSelection = false;
            this.listViewMenuItems.Location = new System.Drawing.Point(579, 212);
            this.listViewMenuItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewMenuItems.Name = "listViewMenuItems";
            this.listViewMenuItems.Size = new System.Drawing.Size(495, 296);
            this.listViewMenuItems.TabIndex = 9;
            this.listViewMenuItems.UseCompatibleStateImageBehavior = false;
            this.listViewMenuItems.View = System.Windows.Forms.View.Details;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Item Name";
            this.ItemName.Width = 200;
            // 
            // ItemPrice
            // 
            this.ItemPrice.Text = "Price";
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 150;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(579, 138);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(57, 25);
            this.lblMenu.TabIndex = 12;
            this.lblMenu.Text = "Menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(1019, 212);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(1, 0, 0, 2);
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAdd.Size = new System.Drawing.Size(55, 52);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "+ ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinus.Location = new System.Drawing.Point(466, 212);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Padding = new System.Windows.Forms.Padding(1, 0, 0, 2);
            this.btnMinus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnMinus.Size = new System.Drawing.Size(55, 52);
            this.btnMinus.TabIndex = 14;
            this.btnMinus.Text = "- ";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click_1);
            // 
            // btnDrinks
            // 
            this.btnDrinks.BackColor = System.Drawing.Color.Teal;
            this.btnDrinks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDrinks.Location = new System.Drawing.Point(32, 85);
            this.btnDrinks.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(220, 55);
            this.btnDrinks.TabIndex = 26;
            this.btnDrinks.Text = "Drinks";
            this.btnDrinks.UseVisualStyleBackColor = false;
            this.btnDrinks.Click += new System.EventHandler(this.btnDrinks_Click_1);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.Teal;
            this.btnPayment.Enabled = false;
            this.btnPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPayment.Location = new System.Drawing.Point(579, 525);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(220, 55);
            this.btnPayment.TabIndex = 27;
            this.btnPayment.Text = "Pay";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnStarters
            // 
            this.btnStarters.BackColor = System.Drawing.Color.Teal;
            this.btnStarters.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStarters.Location = new System.Drawing.Point(301, 85);
            this.btnStarters.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnStarters.Name = "btnStarters";
            this.btnStarters.Size = new System.Drawing.Size(220, 55);
            this.btnStarters.TabIndex = 28;
            this.btnStarters.Text = "Starters";
            this.btnStarters.UseVisualStyleBackColor = false;
            this.btnStarters.Click += new System.EventHandler(this.btnStarters_Click_1);
            // 
            // btnMains
            // 
            this.btnMains.BackColor = System.Drawing.Color.Teal;
            this.btnMains.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMains.Location = new System.Drawing.Point(579, 85);
            this.btnMains.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnMains.Name = "btnMains";
            this.btnMains.Size = new System.Drawing.Size(220, 55);
            this.btnMains.TabIndex = 29;
            this.btnMains.Text = "Mains";
            this.btnMains.UseVisualStyleBackColor = false;
            this.btnMains.Click += new System.EventHandler(this.btnMains_Click_1);
            // 
            // btnDesserts
            // 
            this.btnDesserts.BackColor = System.Drawing.Color.Teal;
            this.btnDesserts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDesserts.Location = new System.Drawing.Point(854, 85);
            this.btnDesserts.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnDesserts.Name = "btnDesserts";
            this.btnDesserts.Size = new System.Drawing.Size(220, 55);
            this.btnDesserts.TabIndex = 30;
            this.btnDesserts.Text = "Deserts";
            this.btnDesserts.UseVisualStyleBackColor = false;
            this.btnDesserts.Click += new System.EventHandler(this.btnDesserts_Click_1);
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(854, 36);
            this.lblEmployeeName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(299, 25);
            this.lblEmployeeName.TabIndex = 0;
            this.lblEmployeeName.Text = "Employee Name: Avornicesei Catalin";
            this.lblEmployeeName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblEmployeeName_MouseClick);
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "New item selection";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.miniToolStrip.Location = new System.Drawing.Point(238, 2);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Padding = new System.Windows.Forms.Padding(14, 2, 0, 2);
            this.miniToolStrip.Size = new System.Drawing.Size(1109, 33);
            this.miniToolStrip.TabIndex = 32;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(116, 29);
            this.toolStripMenuItem2.Text = "Dashboard";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(102, 34);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(108, 29);
            this.toolStripMenuItem1.Text = "Table view";
            // 
            // pnlTakeOrder
            // 
            this.pnlTakeOrder.Controls.Add(this.btnModify);
            this.pnlTakeOrder.Controls.Add(this.lblEmployeeName);
            this.pnlTakeOrder.Controls.Add(this.btnDesserts);
            this.pnlTakeOrder.Controls.Add(this.btnMains);
            this.pnlTakeOrder.Controls.Add(this.btnStarters);
            this.pnlTakeOrder.Controls.Add(this.btnPayment);
            this.pnlTakeOrder.Controls.Add(this.btnDrinks);
            this.pnlTakeOrder.Controls.Add(this.btnMinus);
            this.pnlTakeOrder.Controls.Add(this.btnAdd);
            this.pnlTakeOrder.Controls.Add(this.lblMenu);
            this.pnlTakeOrder.Controls.Add(this.listViewMenuItems);
            this.pnlTakeOrder.Controls.Add(this.btnCancel);
            this.pnlTakeOrder.Controls.Add(this.btnTake);
            this.pnlTakeOrder.Controls.Add(this.listViewOrderItems);
            this.pnlTakeOrder.Controls.Add(this.lblTableNumber);
            this.pnlTakeOrder.Location = new System.Drawing.Point(20, 62);
            this.pnlTakeOrder.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.pnlTakeOrder.Name = "pnlTakeOrder";
            this.pnlTakeOrder.Size = new System.Drawing.Size(1109, 606);
            this.pnlTakeOrder.TabIndex = 4;
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Teal;
            this.btnModify.Enabled = false;
            this.btnModify.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModify.Location = new System.Drawing.Point(301, 525);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(220, 55);
            this.btnModify.TabIndex = 31;
            this.btnModify.Text = "Modify Order";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(14, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1109, 33);
            this.menuStrip2.TabIndex = 32;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBar,
            this.MenuKitchen,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1141, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuBar
            // 
            this.MenuBar.Enabled = false;
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(93, 29);
            this.MenuBar.Text = "Bar view";
            // 
            // MenuKitchen
            // 
            this.MenuKitchen.Enabled = false;
            this.MenuKitchen.Name = "MenuKitchen";
            this.MenuKitchen.Size = new System.Drawing.Size(125, 29);
            this.MenuKitchen.Text = "Kitchen view";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(108, 29);
            this.toolStripMenuItem4.Text = "Table view";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // TakeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 750);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlTakeOrder);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TakeOrder";
            this.pnlTakeOrder.ResumeLayout(false);
            this.pnlTakeOrder.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTableNumber;
        private System.Windows.Forms.ListView listViewOrderItems;
        private System.Windows.Forms.ColumnHeader Name_Item;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader Note;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListView listViewMenuItems;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader ItemPrice;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnStarters;
        private System.Windows.Forms.Button btnMains;
        private System.Windows.Forms.Button btnDesserts;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.MenuStrip miniToolStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel pnlTakeOrder;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuBar;
        private System.Windows.Forms.ToolStripMenuItem MenuKitchen;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem MenuBill;
    }
}