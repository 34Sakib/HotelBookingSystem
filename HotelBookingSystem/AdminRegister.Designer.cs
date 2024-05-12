
namespace HotelBookingSystem
{
    partial class AdminRegister
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
            this.adminregister_to_login = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AdminRegister_loginbtn = new System.Windows.Forms.Button();
            this.adminregister_checkpass = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.adminRegister_password = new System.Windows.Forms.TextBox();
            this.adminRegister_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adminRegister_securityCode = new System.Windows.Forms.TextBox();
            this.close = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminregister_to_login
            // 
            this.adminregister_to_login.AutoSize = true;
            this.adminregister_to_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminregister_to_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminregister_to_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            this.adminregister_to_login.Location = new System.Drawing.Point(86, 393);
            this.adminregister_to_login.Name = "adminregister_to_login";
            this.adminregister_to_login.Size = new System.Drawing.Size(48, 20);
            this.adminregister_to_login.TabIndex = 35;
            this.adminregister_to_login.Text = "Login";
            this.adminregister_to_login.Click += new System.EventHandler(this.adminregister_to_login_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(28, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Admin?";
            // 
            // AdminRegister_loginbtn
            // 
            this.AdminRegister_loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            this.AdminRegister_loginbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AdminRegister_loginbtn.Location = new System.Drawing.Point(26, 336);
            this.AdminRegister_loginbtn.Name = "AdminRegister_loginbtn";
            this.AdminRegister_loginbtn.Size = new System.Drawing.Size(309, 40);
            this.AdminRegister_loginbtn.TabIndex = 33;
            this.AdminRegister_loginbtn.Text = "Register";
            this.AdminRegister_loginbtn.UseVisualStyleBackColor = false;
            this.AdminRegister_loginbtn.Click += new System.EventHandler(this.AdminRegister_loginbtn_Click);
            // 
            // adminregister_checkpass
            // 
            this.adminregister_checkpass.AutoSize = true;
            this.adminregister_checkpass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.adminregister_checkpass.Location = new System.Drawing.Point(183, 297);
            this.adminregister_checkpass.Name = "adminregister_checkpass";
            this.adminregister_checkpass.Size = new System.Drawing.Size(153, 24);
            this.adminregister_checkpass.TabIndex = 32;
            this.adminregister_checkpass.Text = "Check Password";
            this.adminregister_checkpass.UseVisualStyleBackColor = true;
            this.adminregister_checkpass.CheckedChanged += new System.EventHandler(this.adminregister_checkpass_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(22, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(22, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "User Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 63);
            this.panel1.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(61, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 32);
            this.label2.TabIndex = 27;
            this.label2.Text = "Admin Register";
            // 
            // adminRegister_password
            // 
            this.adminRegister_password.Location = new System.Drawing.Point(27, 253);
            this.adminRegister_password.Name = "adminRegister_password";
            this.adminRegister_password.PasswordChar = '*';
            this.adminRegister_password.Size = new System.Drawing.Size(309, 26);
            this.adminRegister_password.TabIndex = 29;
            // 
            // adminRegister_username
            // 
            this.adminRegister_username.Location = new System.Drawing.Point(27, 183);
            this.adminRegister_username.Name = "adminRegister_username";
            this.adminRegister_username.Size = new System.Drawing.Size(309, 26);
            this.adminRegister_username.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(23, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Security Code:";
            // 
            // adminRegister_securityCode
            // 
            this.adminRegister_securityCode.Location = new System.Drawing.Point(28, 110);
            this.adminRegister_securityCode.Name = "adminRegister_securityCode";
            this.adminRegister_securityCode.Size = new System.Drawing.Size(309, 26);
            this.adminRegister_securityCode.TabIndex = 36;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.close.Location = new System.Drawing.Point(323, 18);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(35, 32);
            this.close.TabIndex = 38;
            this.close.Text = "X";
            // 
            // AdminRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminRegister_securityCode);
            this.Controls.Add(this.adminregister_to_login);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AdminRegister_loginbtn);
            this.Controls.Add(this.adminregister_checkpass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.adminRegister_password);
            this.Controls.Add(this.adminRegister_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminRegister";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adminregister_to_login;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AdminRegister_loginbtn;
        private System.Windows.Forms.CheckBox adminregister_checkpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adminRegister_password;
        private System.Windows.Forms.TextBox adminRegister_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adminRegister_securityCode;
        private System.Windows.Forms.Label close;
    }
}