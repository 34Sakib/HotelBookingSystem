
namespace HotelBookingSystem
{
    partial class ManageUsersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ManageUsers_UserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ManageUsers_Phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ManageUsers_Email = new System.Windows.Forms.TextBox();
            this.ManageUsers_ClearBtn = new System.Windows.Forms.Button();
            this.ManageUsers_DeleteBtn = new System.Windows.Forms.Button();
            this.ManageUsers_UpdateBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ManageUsers_UserID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(23, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(419, 408);
            this.dataGridView1.TabIndex = 65;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(451, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 69;
            this.label1.Text = "User Name:";
            // 
            // ManageUsers_UserName
            // 
            this.ManageUsers_UserName.Location = new System.Drawing.Point(547, 76);
            this.ManageUsers_UserName.Name = "ManageUsers_UserName";
            this.ManageUsers_UserName.Size = new System.Drawing.Size(188, 26);
            this.ManageUsers_UserName.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(483, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 71;
            this.label2.Text = "Phone:";
            // 
            // ManageUsers_Phone
            // 
            this.ManageUsers_Phone.Location = new System.Drawing.Point(547, 123);
            this.ManageUsers_Phone.Name = "ManageUsers_Phone";
            this.ManageUsers_Phone.Size = new System.Drawing.Size(188, 26);
            this.ManageUsers_Phone.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(488, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "Email:";
            // 
            // ManageUsers_Email
            // 
            this.ManageUsers_Email.Location = new System.Drawing.Point(547, 173);
            this.ManageUsers_Email.Name = "ManageUsers_Email";
            this.ManageUsers_Email.Size = new System.Drawing.Size(188, 26);
            this.ManageUsers_Email.TabIndex = 72;
            // 
            // ManageUsers_ClearBtn
            // 
            this.ManageUsers_ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            this.ManageUsers_ClearBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ManageUsers_ClearBtn.Location = new System.Drawing.Point(571, 342);
            this.ManageUsers_ClearBtn.Name = "ManageUsers_ClearBtn";
            this.ManageUsers_ClearBtn.Size = new System.Drawing.Size(128, 35);
            this.ManageUsers_ClearBtn.TabIndex = 76;
            this.ManageUsers_ClearBtn.Text = "CLEAR";
            this.ManageUsers_ClearBtn.UseVisualStyleBackColor = false;
            this.ManageUsers_ClearBtn.Click += new System.EventHandler(this.ManageUsers_ClearBtn_Click);
            // 
            // ManageUsers_DeleteBtn
            // 
            this.ManageUsers_DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            this.ManageUsers_DeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ManageUsers_DeleteBtn.Location = new System.Drawing.Point(571, 282);
            this.ManageUsers_DeleteBtn.Name = "ManageUsers_DeleteBtn";
            this.ManageUsers_DeleteBtn.Size = new System.Drawing.Size(128, 35);
            this.ManageUsers_DeleteBtn.TabIndex = 75;
            this.ManageUsers_DeleteBtn.Text = "DELETE";
            this.ManageUsers_DeleteBtn.UseVisualStyleBackColor = false;
            this.ManageUsers_DeleteBtn.Click += new System.EventHandler(this.ManageUsers_DeleteBtn_Click);
            // 
            // ManageUsers_UpdateBtn
            // 
            this.ManageUsers_UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            this.ManageUsers_UpdateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ManageUsers_UpdateBtn.Location = new System.Drawing.Point(571, 224);
            this.ManageUsers_UpdateBtn.Name = "ManageUsers_UpdateBtn";
            this.ManageUsers_UpdateBtn.Size = new System.Drawing.Size(128, 35);
            this.ManageUsers_UpdateBtn.TabIndex = 74;
            this.ManageUsers_UpdateBtn.Text = "UPDATE";
            this.ManageUsers_UpdateBtn.UseVisualStyleBackColor = false;
            this.ManageUsers_UpdateBtn.Click += new System.EventHandler(this.ManageUsers_UpdateBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(474, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 78;
            this.label4.Text = "User ID:";
            // 
            // ManageUsers_UserID
            // 
            this.ManageUsers_UserID.Location = new System.Drawing.Point(547, 32);
            this.ManageUsers_UserID.Name = "ManageUsers_UserID";
            this.ManageUsers_UserID.Size = new System.Drawing.Size(188, 26);
            this.ManageUsers_UserID.TabIndex = 77;
            // 
            // ManageUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ManageUsers_UserID);
            this.Controls.Add(this.ManageUsers_ClearBtn);
            this.Controls.Add(this.ManageUsers_DeleteBtn);
            this.Controls.Add(this.ManageUsers_UpdateBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ManageUsers_Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ManageUsers_Phone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ManageUsers_UserName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManageUsersForm";
            this.Size = new System.Drawing.Size(750, 450);
            this.Load += new System.EventHandler(this.ManageUsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ManageUsers_UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ManageUsers_Phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ManageUsers_Email;
        private System.Windows.Forms.Button ManageUsers_ClearBtn;
        private System.Windows.Forms.Button ManageUsers_DeleteBtn;
        private System.Windows.Forms.Button ManageUsers_UpdateBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ManageUsers_UserID;
    }
}
