
namespace HotelBookingSystem
{
    partial class ManagePayment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ManagePayments_PaymentMethod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ManagePayments_PaymentId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ManagePayments_ClearBtn = new System.Windows.Forms.Button();
            this.ManagePayment_DeleteBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ManagePayments_PaymentAmount = new System.Windows.Forms.TextBox();
            this.ManagePayments_UserId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(465, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 87;
            this.label4.Text = "Payment";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(465, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 86;
            this.label3.Text = "Payment";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ManagePayments_PaymentMethod
            // 
            this.ManagePayments_PaymentMethod.Location = new System.Drawing.Point(542, 112);
            this.ManagePayments_PaymentMethod.Name = "ManagePayments_PaymentMethod";
            this.ManagePayments_PaymentMethod.Size = new System.Drawing.Size(188, 26);
            this.ManagePayments_PaymentMethod.TabIndex = 85;
            this.ManagePayments_PaymentMethod.TextChanged += new System.EventHandler(this.ManagePayments_PaymentMethod_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(472, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 83;
            this.label2.Text = "User ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(443, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 82;
            this.label1.Text = "Payment ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ManagePayments_PaymentId
            // 
            this.ManagePayments_PaymentId.Location = new System.Drawing.Point(542, 22);
            this.ManagePayments_PaymentId.Name = "ManagePayments_PaymentId";
            this.ManagePayments_PaymentId.Size = new System.Drawing.Size(188, 26);
            this.ManagePayments_PaymentId.TabIndex = 81;
            this.ManagePayments_PaymentId.TextChanged += new System.EventHandler(this.ManagePayments_PaymentId_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(18, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(419, 408);
            this.dataGridView1.TabIndex = 79;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ManagePayments_ClearBtn
            // 
            this.ManagePayments_ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            this.ManagePayments_ClearBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ManagePayments_ClearBtn.Location = new System.Drawing.Point(571, 295);
            this.ManagePayments_ClearBtn.Name = "ManagePayments_ClearBtn";
            this.ManagePayments_ClearBtn.Size = new System.Drawing.Size(128, 35);
            this.ManagePayments_ClearBtn.TabIndex = 78;
            this.ManagePayments_ClearBtn.Text = "CLEAR";
            this.ManagePayments_ClearBtn.UseVisualStyleBackColor = false;
            this.ManagePayments_ClearBtn.Click += new System.EventHandler(this.ManageHotels_ClearBtn_Click);
            // 
            // ManagePayment_DeleteBtn
            // 
            this.ManagePayment_DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            this.ManagePayment_DeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ManagePayment_DeleteBtn.Location = new System.Drawing.Point(571, 225);
            this.ManagePayment_DeleteBtn.Name = "ManagePayment_DeleteBtn";
            this.ManagePayment_DeleteBtn.Size = new System.Drawing.Size(128, 35);
            this.ManagePayment_DeleteBtn.TabIndex = 77;
            this.ManagePayment_DeleteBtn.Text = "DELETE";
            this.ManagePayment_DeleteBtn.UseVisualStyleBackColor = false;
            this.ManagePayment_DeleteBtn.Click += new System.EventHandler(this.ManageHotels_DeleteBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(469, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 89;
            this.label5.Text = "Method:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(469, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 90;
            this.label6.Text = "Amount:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ManagePayments_PaymentAmount
            // 
            this.ManagePayments_PaymentAmount.Location = new System.Drawing.Point(543, 167);
            this.ManagePayments_PaymentAmount.Name = "ManagePayments_PaymentAmount";
            this.ManagePayments_PaymentAmount.Size = new System.Drawing.Size(188, 26);
            this.ManagePayments_PaymentAmount.TabIndex = 91;
            this.ManagePayments_PaymentAmount.TextChanged += new System.EventHandler(this.ManagePayments_PaymentAmount_TextChanged);
            // 
            // ManagePayments_UserId
            // 
            this.ManagePayments_UserId.Location = new System.Drawing.Point(543, 68);
            this.ManagePayments_UserId.Name = "ManagePayments_UserId";
            this.ManagePayments_UserId.Size = new System.Drawing.Size(188, 26);
            this.ManagePayments_UserId.TabIndex = 92;
            this.ManagePayments_UserId.TextChanged += new System.EventHandler(this.ManagePayments_UserId_TextChanged);
            // 
            // ManagePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ManagePayments_UserId);
            this.Controls.Add(this.ManagePayments_PaymentAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ManagePayments_PaymentMethod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ManagePayments_PaymentId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ManagePayments_ClearBtn);
            this.Controls.Add(this.ManagePayment_DeleteBtn);
            this.Name = "ManagePayment";
            this.Size = new System.Drawing.Size(750, 450);
            this.Load += new System.EventHandler(this.ManagePayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ManagePayments_PaymentMethod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ManagePayments_PaymentId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ManagePayments_ClearBtn;
        private System.Windows.Forms.Button ManagePayment_DeleteBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ManagePayments_PaymentAmount;
        private System.Windows.Forms.TextBox ManagePayments_UserId;
    }
}
