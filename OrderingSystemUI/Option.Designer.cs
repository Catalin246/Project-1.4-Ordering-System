namespace OrderingSystemUI
{
    partial class Option
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeRole = new System.Windows.Forms.Label();
            this.lblText1 = new System.Windows.Forms.Label();
            this.labelEmployeName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.labelEmployeRole = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(76, 20);
            this.toolStripMenuItem1.Text = "Dashboard";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(63, 20);
            this.toolStripMenuItem2.Text = "Bar view";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(86, 20);
            this.toolStripMenuItem3.Text = "Kitchen view";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(73, 20);
            this.toolStripMenuItem4.Text = "Table view";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(62, 20);
            this.toolStripMenuItem5.Text = "Bill view";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmployeeName.Location = new System.Drawing.Point(29, 114);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(155, 28);
            this.lblEmployeeName.TabIndex = 3;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // lblEmployeeRole
            // 
            this.lblEmployeeRole.AutoSize = true;
            this.lblEmployeeRole.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmployeeRole.Location = new System.Drawing.Point(29, 193);
            this.lblEmployeeRole.Name = "lblEmployeeRole";
            this.lblEmployeeRole.Size = new System.Drawing.Size(141, 28);
            this.lblEmployeeRole.TabIndex = 5;
            this.lblEmployeeRole.Text = "Employee Role";
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblText1.Location = new System.Drawing.Point(368, 150);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(308, 28);
            this.lblText1.TabIndex = 6;
            this.lblText1.Text = "Are you sure you want to logout ?";
            // 
            // labelEmployeName
            // 
            this.labelEmployeName.AutoSize = true;
            this.labelEmployeName.Location = new System.Drawing.Point(190, 125);
            this.labelEmployeName.Name = "labelEmployeName";
            this.labelEmployeName.Size = new System.Drawing.Size(16, 15);
            this.labelEmployeName.TabIndex = 7;
            this.labelEmployeName.Text = "...";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(407, 204);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(213, 63);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // labelEmployeRole
            // 
            this.labelEmployeRole.AutoSize = true;
            this.labelEmployeRole.Location = new System.Drawing.Point(176, 204);
            this.labelEmployeRole.Name = "labelEmployeRole";
            this.labelEmployeRole.Size = new System.Drawing.Size(16, 15);
            this.labelEmployeRole.TabIndex = 9;
            this.labelEmployeRole.Text = "...";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(34, 37);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(48, 39);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.labelEmployeRole);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.labelEmployeName);
            this.Controls.Add(this.lblText1);
            this.Controls.Add(this.lblEmployeeRole);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Option";
            this.Text = "Option";
            this.Load += new System.EventHandler(this.Option_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEmployeeRole;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Label labelEmployeName;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label labelEmployeRole;
        private System.Windows.Forms.Button btnBack;
    }
}