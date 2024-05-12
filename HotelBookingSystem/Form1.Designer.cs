
namespace HotelBookingSystem
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.login_username = new System.Windows.Forms.TextBox();
            this.login_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.login_checkpass = new System.Windows.Forms.CheckBox();
            this.login_loginbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.login_to_resister = new System.Windows.Forms.Label();
            this.login_to_adminLogin = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginform_close = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 450);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(436, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN";
            // 
            // login_username
            // 
            this.login_username.Location = new System.Drawing.Point(443, 145);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(309, 26);
            this.login_username.TabIndex = 3;
            // 
            // login_password
            // 
            this.login_password.Location = new System.Drawing.Point(443, 215);
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '*';
            this.login_password.Size = new System.Drawing.Size(309, 26);
            this.login_password.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(438, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "User Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(438, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // login_checkpass
            // 
            this.login_checkpass.AutoSize = true;
            this.login_checkpass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.login_checkpass.Location = new System.Drawing.Point(599, 257);
            this.login_checkpass.Name = "login_checkpass";
            this.login_checkpass.Size = new System.Drawing.Size(153, 24);
            this.login_checkpass.TabIndex = 7;
            this.login_checkpass.Text = "Check Password";
            this.login_checkpass.UseVisualStyleBackColor = true;
            this.login_checkpass.CheckedChanged += new System.EventHandler(this.login_checkpass_CheckedChanged);
            // 
            // login_loginbtn
            // 
            this.login_loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            this.login_loginbtn.Location = new System.Drawing.Point(442, 289);
            this.login_loginbtn.Name = "login_loginbtn";
            this.login_loginbtn.Size = new System.Drawing.Size(309, 40);
            this.login_loginbtn.TabIndex = 8;
            this.login_loginbtn.Text = "Login";
            this.login_loginbtn.UseVisualStyleBackColor = false;
            this.login_loginbtn.Click += new System.EventHandler(this.login_loginbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(439, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "New User?";
            // 
            // login_to_resister
            // 
            this.login_to_resister.AutoSize = true;
            this.login_to_resister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_to_resister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_to_resister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            this.login_to_resister.Location = new System.Drawing.Point(532, 348);
            this.login_to_resister.Name = "login_to_resister";
            this.login_to_resister.Size = new System.Drawing.Size(69, 20);
            this.login_to_resister.TabIndex = 10;
            this.login_to_resister.Text = "Register";
            this.login_to_resister.Click += new System.EventHandler(this.login_to_resister_Click);
            // 
            // login_to_adminLogin
            // 
            this.login_to_adminLogin.AutoSize = true;
            this.login_to_adminLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_to_adminLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_to_adminLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            this.login_to_adminLogin.Location = new System.Drawing.Point(508, 382);
            this.login_to_adminLogin.Name = "login_to_adminLogin";
            this.login_to_adminLogin.Size = new System.Drawing.Size(48, 20);
            this.login_to_adminLogin.TabIndex = 12;
            this.login_to_adminLogin.Text = "Login";
            this.login_to_adminLogin.Click += new System.EventHandler(this.login_to_adminLogin_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(439, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Admin?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(439, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Welcome Back! Please login to your account";
            // 
            // loginform_close
            // 
            this.loginform_close.AutoSize = true;
            this.loginform_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginform_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginform_close.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginform_close.Location = new System.Drawing.Point(746, 9);
            this.loginform_close.Name = "loginform_close";
            this.loginform_close.Size = new System.Drawing.Size(42, 40);
            this.loginform_close.TabIndex = 15;
            this.loginform_close.Text = "X";
            this.loginform_close.Click += new System.EventHandler(this.loginform_close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelBookingSystem.Properties.Resources.Hotel;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 449);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginform_close);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login_to_adminLogin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.login_to_resister);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.login_loginbtn);
            this.Controls.Add(this.login_checkpass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.login_username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox login_checkpass;
        private System.Windows.Forms.Button login_loginbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label login_to_resister;
        private System.Windows.Forms.Label login_to_adminLogin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label loginform_close;
    }
}

