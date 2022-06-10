namespace OrderingSystemUI
{
    partial class Login
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPasscode = new System.Windows.Forms.Label();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.txtBoxPasscode = new System.Windows.Forms.TextBox();
            this.lblWrongUserName = new System.Windows.Forms.Label();
            this.lblwrongPasscode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(305, 311);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(140, 36);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(241, 172);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 15);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Username";
            // 
            // lblPasscode
            // 
            this.lblPasscode.AutoSize = true;
            this.lblPasscode.Location = new System.Drawing.Point(241, 235);
            this.lblPasscode.Name = "lblPasscode";
            this.lblPasscode.Size = new System.Drawing.Size(56, 15);
            this.lblPasscode.TabIndex = 3;
            this.lblPasscode.Text = "Passcode";
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Location = new System.Drawing.Point(326, 169);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(182, 23);
            this.txtBoxUsername.TabIndex = 4;
            // 
            // txtBoxPasscode
            // 
            this.txtBoxPasscode.Location = new System.Drawing.Point(326, 227);
            this.txtBoxPasscode.Name = "txtBoxPasscode";
            this.txtBoxPasscode.PasswordChar = '*';
            this.txtBoxPasscode.Size = new System.Drawing.Size(182, 23);
            this.txtBoxPasscode.TabIndex = 5;
            this.txtBoxPasscode.UseSystemPasswordChar = true;
            // 
            // lblWrongUserName
            // 
            this.lblWrongUserName.AutoSize = true;
            this.lblWrongUserName.Location = new System.Drawing.Point(326, 195);
            this.lblWrongUserName.Name = "lblWrongUserName";
            this.lblWrongUserName.Size = new System.Drawing.Size(0, 15);
            this.lblWrongUserName.TabIndex = 6;
            // 
            // lblwrongPasscode
            // 
            this.lblwrongPasscode.AutoSize = true;
            this.lblwrongPasscode.Location = new System.Drawing.Point(326, 253);
            this.lblwrongPasscode.Name = "lblwrongPasscode";
            this.lblwrongPasscode.Size = new System.Drawing.Size(0, 15);
            this.lblwrongPasscode.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblwrongPasscode);
            this.Controls.Add(this.lblWrongUserName);
            this.Controls.Add(this.txtBoxPasscode);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.lblPasscode);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPasscode;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.TextBox txtBoxPasscode;
        private System.Windows.Forms.Label lblWrongUserName;
        private System.Windows.Forms.Label lblwrongPasscode;
    }
}