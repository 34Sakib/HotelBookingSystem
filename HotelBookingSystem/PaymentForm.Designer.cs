
namespace HotelBookingSystem
{
    partial class PaymentForm
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
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PaymentForm_PaymentAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PaymentForm_PaymentMethod = new System.Windows.Forms.ComboBox();
            this.PaymentForm_Confirm_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 61);
            this.panel1.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(812, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 29);
            this.label12.TabIndex = 17;
            this.label12.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(122, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Payment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(314, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 36);
            this.label2.TabIndex = 18;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 20);
            this.label9.TabIndex = 47;
            this.label9.Text = "Payment Method:";
            // 
            // PaymentForm_PaymentAmount
            // 
            this.PaymentForm_PaymentAmount.Location = new System.Drawing.Point(22, 225);
            this.PaymentForm_PaymentAmount.Name = "PaymentForm_PaymentAmount";
            this.PaymentForm_PaymentAmount.Size = new System.Drawing.Size(311, 26);
            this.PaymentForm_PaymentAmount.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Payment Amount:";
            // 
            // PaymentForm_PaymentMethod
            // 
            this.PaymentForm_PaymentMethod.FormattingEnabled = true;
            this.PaymentForm_PaymentMethod.Items.AddRange(new object[] {
            "Credit Card",
            "Bkash",
            "Nagad",
            "Paypal",
            "Mastercard"});
            this.PaymentForm_PaymentMethod.Location = new System.Drawing.Point(22, 136);
            this.PaymentForm_PaymentMethod.Name = "PaymentForm_PaymentMethod";
            this.PaymentForm_PaymentMethod.Size = new System.Drawing.Size(311, 28);
            this.PaymentForm_PaymentMethod.TabIndex = 49;
            // 
            // PaymentForm_Confirm_btn
            // 
            this.PaymentForm_Confirm_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            this.PaymentForm_Confirm_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PaymentForm_Confirm_btn.Location = new System.Drawing.Point(75, 292);
            this.PaymentForm_Confirm_btn.Name = "PaymentForm_Confirm_btn";
            this.PaymentForm_Confirm_btn.Size = new System.Drawing.Size(202, 46);
            this.PaymentForm_Confirm_btn.TabIndex = 55;
            this.PaymentForm_Confirm_btn.Text = "Confirm Payment";
            this.PaymentForm_Confirm_btn.UseVisualStyleBackColor = false;
            this.PaymentForm_Confirm_btn.Click += new System.EventHandler(this.PaymentForm_Confirm_btn_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Controls.Add(this.PaymentForm_Confirm_btn);
            this.Controls.Add(this.PaymentForm_PaymentMethod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PaymentForm_PaymentAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PaymentForm_PaymentAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PaymentForm_PaymentMethod;
        private System.Windows.Forms.Button PaymentForm_Confirm_btn;
    }
}