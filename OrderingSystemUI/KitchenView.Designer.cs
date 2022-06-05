namespace OrderingSystemUI
{
    partial class KitchenView
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
            this.components = new System.ComponentModel.Container();
            this.listViewKitchen = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.colTableNo = new System.Windows.Forms.ColumnHeader();
            this.colTime = new System.Windows.Forms.ColumnHeader();
            this.colCategory = new System.Windows.Forms.ColumnHeader();
            this.colAmount = new System.Windows.Forms.ColumnHeader();
            this.colFoodName = new System.Windows.Forms.ColumnHeader();
            this.colOrderNote = new System.Windows.Forms.ColumnHeader();
            this.colStatus = new System.Windows.Forms.ColumnHeader();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnReadyToServe = new System.Windows.Forms.Button();
            this.btnViewOrderNote = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBoxShowOrders = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewKitchen
            // 
            this.listViewKitchen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.colTableNo,
            this.colTime,
            this.colCategory,
            this.colAmount,
            this.colFoodName,
            this.colOrderNote,
            this.colStatus});
            this.listViewKitchen.HideSelection = false;
            this.listViewKitchen.Location = new System.Drawing.Point(3, 89);
            this.listViewKitchen.Name = "listViewKitchen";
            this.listViewKitchen.Size = new System.Drawing.Size(842, 346);
            this.listViewKitchen.TabIndex = 12;
            this.listViewKitchen.UseCompatibleStateImageBehavior = false;
            this.listViewKitchen.View = System.Windows.Forms.View.Details;
            this.listViewKitchen.SelectedIndexChanged += new System.EventHandler(this.listViewKitchen_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Order No";
            this.columnHeader1.Width = 70;
            // 
            // colTableNo
            // 
            this.colTableNo.Text = "Table No";
            this.colTableNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTableNo.Width = 70;
            // 
            // colTime
            // 
            this.colTime.Text = "Time";
            this.colTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colCategory
            // 
            this.colCategory.Text = "Category";
            this.colCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCategory.Width = 90;
            // 
            // colAmount
            // 
            this.colAmount.Text = "Amount";
            this.colAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colAmount.Width = 80;
            // 
            // colFoodName
            // 
            this.colFoodName.Text = "Food Name";
            this.colFoodName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colFoodName.Width = 280;
            // 
            // colOrderNote
            // 
            this.colOrderNote.Text = "Order Note";
            this.colOrderNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colOrderNote.Width = 80;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colStatus.Width = 90;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(398, 1);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(50, 20);
            this.lblTime.TabIndex = 17;
            this.lblTime.Text = "label1";
            // 
            // btnReadyToServe
            // 
            this.btnReadyToServe.BackColor = System.Drawing.Color.Lime;
            this.btnReadyToServe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReadyToServe.Location = new System.Drawing.Point(640, 441);
            this.btnReadyToServe.Name = "btnReadyToServe";
            this.btnReadyToServe.Size = new System.Drawing.Size(205, 46);
            this.btnReadyToServe.TabIndex = 15;
            this.btnReadyToServe.Text = "Ready To Serve";
            this.btnReadyToServe.UseVisualStyleBackColor = false;
            this.btnReadyToServe.Click += new System.EventHandler(this.btnReadyToServe_Click);
            // 
            // btnViewOrderNote
            // 
            this.btnViewOrderNote.BackColor = System.Drawing.Color.Teal;
            this.btnViewOrderNote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewOrderNote.Location = new System.Drawing.Point(4, 441);
            this.btnViewOrderNote.Name = "btnViewOrderNote";
            this.btnViewOrderNote.Size = new System.Drawing.Size(205, 46);
            this.btnViewOrderNote.TabIndex = 13;
            this.btnViewOrderNote.Text = "View Order Note";
            this.btnViewOrderNote.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(724, 57);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 23;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(597, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Select:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(719, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBoxShowOrders
            // 
            this.comboBoxShowOrders.FormattingEnabled = true;
            this.comboBoxShowOrders.Location = new System.Drawing.Point(166, 57);
            this.comboBoxShowOrders.Name = "comboBoxShowOrders";
            this.comboBoxShowOrders.Size = new System.Drawing.Size(183, 23);
            this.comboBoxShowOrders.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "View Orders:";
            // 
            // KitchenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 495);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxShowOrders);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listViewKitchen);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnReadyToServe);
            this.Controls.Add(this.btnViewOrderNote);
            this.Name = "KitchenView";
            this.Text = "KitchenView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewKitchen;
        private System.Windows.Forms.ColumnHeader colTableNo;
        private System.Windows.Forms.ColumnHeader colTime;
        private System.Windows.Forms.ColumnHeader colCategory;
        private System.Windows.Forms.ColumnHeader colAmount;
        private System.Windows.Forms.ColumnHeader colFoodName;
        private System.Windows.Forms.ColumnHeader colOrderNote;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnReadyToServe;
        private System.Windows.Forms.Button btnViewOrderNote;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ComboBox comboBoxShowOrders;
        private System.Windows.Forms.Label label1;
    }
}