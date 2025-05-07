
namespace HotelBookingSystem
{
    partial class AdminDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AdminDashboard_ManagePaymentsBtn = new System.Windows.Forms.Button();
            this.AdminDashboard_ManageReviewsBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AdminDashboard_ManageUsersBtn = new System.Windows.Forms.Button();
            this.AdminDashboard_ManageHotelsBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.manageUsersForm1 = new HotelBookingSystem.ManageUsersForm();
            this.managePayment2 = new HotelBookingSystem.ManagePayment();
            this.managePayment1 = new HotelBookingSystem.ManagePayment();
            this.manageReview1 = new HotelBookingSystem.ManageReview();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.overview1 = new HotelBookingSystem.Overview();
            this.manageUsersForm2 = new HotelBookingSystem.ManageUsersForm();
            this.manageReview2 = new HotelBookingSystem.ManageReview();
            this.managePayment3 = new HotelBookingSystem.ManagePayment();
            this.manageHotelForm1 = new HotelBookingSystem.ManageHotelForm();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(60, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "ADMIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "DASHBOARD";
            // 
            // AdminDashboard_ManagePaymentsBtn
            // 
            this.AdminDashboard_ManagePaymentsBtn.BackColor = System.Drawing.Color.White;
            this.AdminDashboard_ManagePaymentsBtn.Location = new System.Drawing.Point(21, 294);
            this.AdminDashboard_ManagePaymentsBtn.Name = "AdminDashboard_ManagePaymentsBtn";
            this.AdminDashboard_ManagePaymentsBtn.Size = new System.Drawing.Size(178, 40);
            this.AdminDashboard_ManagePaymentsBtn.TabIndex = 11;
            this.AdminDashboard_ManagePaymentsBtn.Text = "Manage Payments";
            this.AdminDashboard_ManagePaymentsBtn.UseVisualStyleBackColor = false;
            this.AdminDashboard_ManagePaymentsBtn.Click += new System.EventHandler(this.AdminDashboard_ManagePaymentsBtn_Click);
            // 
            // AdminDashboard_ManageReviewsBtn
            // 
            this.AdminDashboard_ManageReviewsBtn.BackColor = System.Drawing.Color.White;
            this.AdminDashboard_ManageReviewsBtn.Location = new System.Drawing.Point(21, 355);
            this.AdminDashboard_ManageReviewsBtn.Name = "AdminDashboard_ManageReviewsBtn";
            this.AdminDashboard_ManageReviewsBtn.Size = new System.Drawing.Size(178, 40);
            this.AdminDashboard_ManageReviewsBtn.TabIndex = 12;
            this.AdminDashboard_ManageReviewsBtn.Text = "Manage Reviews";
            this.AdminDashboard_ManageReviewsBtn.UseVisualStyleBackColor = false;
            this.AdminDashboard_ManageReviewsBtn.Click += new System.EventHandler(this.AdminDashboard_ManageReviewsBtn_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.AdminDashboard_ManageUsersBtn);
            this.panel1.Controls.Add(this.AdminDashboard_ManageHotelsBtn);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.AdminDashboard_ManageReviewsBtn);
            this.panel1.Controls.Add(this.AdminDashboard_ManagePaymentsBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 495);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AdminDashboard_ManageUsersBtn
            // 
            this.AdminDashboard_ManageUsersBtn.BackColor = System.Drawing.Color.White;
            this.AdminDashboard_ManageUsersBtn.Location = new System.Drawing.Point(22, 230);
            this.AdminDashboard_ManageUsersBtn.Name = "AdminDashboard_ManageUsersBtn";
            this.AdminDashboard_ManageUsersBtn.Size = new System.Drawing.Size(178, 40);
            this.AdminDashboard_ManageUsersBtn.TabIndex = 15;
            this.AdminDashboard_ManageUsersBtn.Text = "Manage Users";
            this.AdminDashboard_ManageUsersBtn.UseVisualStyleBackColor = false;
            this.AdminDashboard_ManageUsersBtn.Click += new System.EventHandler(this.AdminDashboard_ManageUsersBtn_Click);
            // 
            // AdminDashboard_ManageHotelsBtn
            // 
            this.AdminDashboard_ManageHotelsBtn.BackColor = System.Drawing.Color.White;
            this.AdminDashboard_ManageHotelsBtn.Location = new System.Drawing.Point(19, 172);
            this.AdminDashboard_ManageHotelsBtn.Name = "AdminDashboard_ManageHotelsBtn";
            this.AdminDashboard_ManageHotelsBtn.Size = new System.Drawing.Size(178, 40);
            this.AdminDashboard_ManageHotelsBtn.TabIndex = 14;
            this.AdminDashboard_ManageHotelsBtn.Text = "Manage Hotels";
            this.AdminDashboard_ManageHotelsBtn.UseVisualStyleBackColor = false;
            this.AdminDashboard_ManageHotelsBtn.Click += new System.EventHandler(this.AdminDashboard_ManageHotelsBtn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(21, 112);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(178, 40);
            this.button4.TabIndex = 13;
            this.button4.Text = "Overview";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.manageUsersForm1);
            this.panel2.Controls.Add(this.managePayment2);
            this.panel2.Controls.Add(this.managePayment1);
            this.panel2.Controls.Add(this.manageReview1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(220, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 64);
            this.panel2.TabIndex = 2;
            // 
            // manageUsersForm1
            // 
            this.manageUsersForm1.Location = new System.Drawing.Point(0, 42);
            this.manageUsersForm1.Name = "manageUsersForm1";
            this.manageUsersForm1.Size = new System.Drawing.Size(750, 450);
            this.manageUsersForm1.TabIndex = 18;
            // 
            // managePayment2
            // 
            this.managePayment2.Location = new System.Drawing.Point(0, 43);
            this.managePayment2.Name = "managePayment2";
            this.managePayment2.Size = new System.Drawing.Size(761, 450);
            this.managePayment2.TabIndex = 4;
            // 
            // managePayment1
            // 
            this.managePayment1.Location = new System.Drawing.Point(0, 45);
            this.managePayment1.Name = "managePayment1";
            this.managePayment1.Size = new System.Drawing.Size(750, 450);
            this.managePayment1.TabIndex = 17;
            // 
            // manageReview1
            // 
            this.manageReview1.Location = new System.Drawing.Point(3, 49);
            this.manageReview1.Name = "manageReview1";
            this.manageReview1.Size = new System.Drawing.Size(750, 450);
            this.manageReview1.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(711, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(210, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Hotel Booking System";
            // 
            // overview1
            // 
            this.overview1.Location = new System.Drawing.Point(220, 42);
            this.overview1.Name = "overview1";
            this.overview1.Size = new System.Drawing.Size(767, 450);
            this.overview1.TabIndex = 7;
            // 
            // manageUsersForm2
            // 
            this.manageUsersForm2.Location = new System.Drawing.Point(220, 42);
            this.manageUsersForm2.Name = "manageUsersForm2";
            this.manageUsersForm2.Size = new System.Drawing.Size(758, 450);
            this.manageUsersForm2.TabIndex = 6;
            // 
            // manageReview2
            // 
            this.manageReview2.Location = new System.Drawing.Point(220, 45);
            this.manageReview2.Name = "manageReview2";
            this.manageReview2.Size = new System.Drawing.Size(758, 450);
            this.manageReview2.TabIndex = 5;
            // 
            // managePayment3
            // 
            this.managePayment3.Location = new System.Drawing.Point(220, 45);
            this.managePayment3.Name = "managePayment3";
            this.managePayment3.Size = new System.Drawing.Size(758, 450);
            this.managePayment3.TabIndex = 4;
            // 
            // manageHotelForm1
            // 
            this.manageHotelForm1.Location = new System.Drawing.Point(220, 45);
            this.manageHotelForm1.Name = "manageHotelForm1";
            this.manageHotelForm1.Size = new System.Drawing.Size(761, 450);
            this.manageHotelForm1.TabIndex = 3;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 494);
            this.Controls.Add(this.overview1);
            this.Controls.Add(this.manageUsersForm2);
            this.Controls.Add(this.manageReview2);
            this.Controls.Add(this.managePayment3);
            this.Controls.Add(this.manageHotelForm1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AdminDashboard_ManagePaymentsBtn;
        private System.Windows.Forms.Button AdminDashboard_ManageReviewsBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AdminDashboard_ManageHotelsBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AdminDashboard_ManageUsersBtn;
        private ManageUsersForm manageUsersForm1;
        private ManagePayment managePayment2;
        private ManagePayment managePayment1;
        private ManageReview manageReview1;
        private ManageHotelForm manageHotelForm1;
        private ManagePayment managePayment3;
        private ManageReview manageReview2;
        private ManageUsersForm manageUsersForm2;
        private Overview overview1;
    }
}