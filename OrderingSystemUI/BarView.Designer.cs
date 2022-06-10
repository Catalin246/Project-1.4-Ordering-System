namespace OrderingSystemUI
{
    partial class BarView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarView));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxShowOrders = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnemployeeName = new System.Windows.Forms.Button();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.comboBoxTable = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewBar = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.colTableNo = new System.Windows.Forms.ColumnHeader();
            this.colTime = new System.Windows.Forms.ColumnHeader();
            this.colCategory = new System.Windows.Forms.ColumnHeader();
            this.colAmount = new System.Windows.Forms.ColumnHeader();
            this.colFoodName = new System.Windows.Forms.ColumnHeader();
            this.colOrderNote = new System.Windows.Forms.ColumnHeader();
            this.colStatus = new System.Windows.Forms.ColumnHeader();
            this.btnReadyToServe = new System.Windows.Forms.Button();
            this.btnViewOrderNote = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 74);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxShowOrders
            // 
            this.comboBoxShowOrders.BackColor = System.Drawing.Color.White;
            this.comboBoxShowOrders.FormattingEnabled = true;
            this.comboBoxShowOrders.Location = new System.Drawing.Point(166, 60);
            this.comboBoxShowOrders.Name = "comboBoxShowOrders";
            this.comboBoxShowOrders.Size = new System.Drawing.Size(183, 23);
            this.comboBoxShowOrders.TabIndex = 36;
            this.comboBoxShowOrders.SelectedIndexChanged += new System.EventHandler(this.comboBoxShowOrders_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 37;
            this.label1.Text = "View Orders:";
            // 
            // btnemployeeName
            // 
            this.btnemployeeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnemployeeName.Location = new System.Drawing.Point(661, 9);
            this.btnemployeeName.Name = "btnemployeeName";
            this.btnemployeeName.Size = new System.Drawing.Size(179, 27);
            this.btnemployeeName.TabIndex = 35;
            this.btnemployeeName.Text = "btnEmployeeName";
            this.btnemployeeName.UseVisualStyleBackColor = false;
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(742, 60);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(103, 23);
            this.comboBoxCourse.TabIndex = 34;
            this.comboBoxCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourse_SelectedIndexChanged);
            // 
            // comboBoxTable
            // 
            this.comboBoxTable.FormattingEnabled = true;
            this.comboBoxTable.Location = new System.Drawing.Point(640, 60);
            this.comboBoxTable.Name = "comboBoxTable";
            this.comboBoxTable.Size = new System.Drawing.Size(96, 23);
            this.comboBoxTable.TabIndex = 33;
            this.comboBoxTable.SelectedIndexChanged += new System.EventHandler(this.comboBoxTable_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(593, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Select:";
            // 
            // listViewBar
            // 
            this.listViewBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listViewBar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.colTableNo,
            this.colTime,
            this.colCategory,
            this.colAmount,
            this.colFoodName,
            this.colOrderNote,
            this.colStatus});
            this.listViewBar.FullRowSelect = true;
            this.listViewBar.GridLines = true;
            this.listViewBar.HideSelection = false;
            this.listViewBar.Location = new System.Drawing.Point(3, 92);
            this.listViewBar.Name = "listViewBar";
            this.listViewBar.Size = new System.Drawing.Size(842, 346);
            this.listViewBar.TabIndex = 28;
            this.listViewBar.UseCompatibleStateImageBehavior = false;
            this.listViewBar.View = System.Windows.Forms.View.Details;
            this.listViewBar.SelectedIndexChanged += new System.EventHandler(this.listViewBar_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Order No";
            this.columnHeader1.Width = 70;
            // 
            // colTableNo
            // 
            this.colTableNo.Text = "Table";
            this.colTableNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTableNo.Width = 40;
            // 
            // colTime
            // 
            this.colTime.Text = "Time";
            this.colTime.Width = 100;
            // 
            // colCategory
            // 
            this.colCategory.Text = "Category";
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
            // btnReadyToServe
            // 
            this.btnReadyToServe.BackColor = System.Drawing.Color.Lime;
            this.btnReadyToServe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReadyToServe.Location = new System.Drawing.Point(640, 444);
            this.btnReadyToServe.Name = "btnReadyToServe";
            this.btnReadyToServe.Size = new System.Drawing.Size(205, 46);
            this.btnReadyToServe.TabIndex = 30;
            this.btnReadyToServe.Text = "Ready To Serve";
            this.btnReadyToServe.UseVisualStyleBackColor = false;
            this.btnReadyToServe.Click += new System.EventHandler(this.btnReadyToServe_Click);
            // 
            // btnViewOrderNote
            // 
            this.btnViewOrderNote.BackColor = System.Drawing.Color.Teal;
            this.btnViewOrderNote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewOrderNote.Location = new System.Drawing.Point(4, 444);
            this.btnViewOrderNote.Name = "btnViewOrderNote";
            this.btnViewOrderNote.Size = new System.Drawing.Size(205, 46);
            this.btnViewOrderNote.TabIndex = 29;
            this.btnViewOrderNote.Text = "View Order Note";
            this.btnViewOrderNote.UseVisualStyleBackColor = false;
            this.btnViewOrderNote.Click += new System.EventHandler(this.btnViewOrderNote_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(398, 4);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(50, 20);
            this.lblTime.TabIndex = 31;
            this.lblTime.Text = "label1";
            // 
            // BarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 495);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxShowOrders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnemployeeName);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.comboBoxTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listViewBar);
            this.Controls.Add(this.btnReadyToServe);
            this.Controls.Add(this.btnViewOrderNote);
            this.Controls.Add(this.lblTime);
            this.Name = "BarView";
            this.Text = "BarView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxShowOrders;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnemployeeName;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.ComboBox comboBoxTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewBar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader colTableNo;
        private System.Windows.Forms.ColumnHeader colTime;
        private System.Windows.Forms.ColumnHeader colCategory;
        private System.Windows.Forms.ColumnHeader colAmount;
        private System.Windows.Forms.ColumnHeader colFoodName;
        private System.Windows.Forms.ColumnHeader colOrderNote;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.Button btnReadyToServe;
        private System.Windows.Forms.Button btnViewOrderNote;
        private System.Windows.Forms.Label lblTime;
    }
}