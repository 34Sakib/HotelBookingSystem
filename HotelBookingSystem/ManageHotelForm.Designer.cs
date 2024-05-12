
namespace HotelBookingSystem
{
    partial class ManageHotelForm
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
            this.ManageHotels_PicUploadBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ManageHotels_ClearBtn = new System.Windows.Forms.Button();
            this.ManageHotels_DeleteBtn = new System.Windows.Forms.Button();
            this.ManageHotels_UpdateBtn = new System.Windows.Forms.Button();
            this.ManageHotels_AddBtn = new System.Windows.Forms.Button();
            this.ManageHotels_Picture = new System.Windows.Forms.PictureBox();
            this.ManageHotels_Package = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ManageHotels_Cost = new System.Windows.Forms.TextBox();
            this.ManageHotels_City = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ManageHotels_HotelName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageHotels_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // ManageHotels_PicUploadBtn
            // 
            this.ManageHotels_PicUploadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            this.ManageHotels_PicUploadBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ManageHotels_PicUploadBtn.Location = new System.Drawing.Point(603, 409);
            this.ManageHotels_PicUploadBtn.Name = "ManageHotels_PicUploadBtn";
            this.ManageHotels_PicUploadBtn.Size = new System.Drawing.Size(125, 35);
            this.ManageHotels_PicUploadBtn.TabIndex = 65;
            this.ManageHotels_PicUploadBtn.Text = "UPLOAD";
            this.ManageHotels_PicUploadBtn.UseVisualStyleBackColor = false;
            this.ManageHotels_PicUploadBtn.Click += new System.EventHandler(this.ManageHotels_PicUploadBtn_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(16, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(419, 408);
            this.dataGridView1.TabIndex = 64;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ManageHotels_ClearBtn
            // 
            this.ManageHotels_ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            this.ManageHotels_ClearBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ManageHotels_ClearBtn.Location = new System.Drawing.Point(603, 262);
            this.ManageHotels_ClearBtn.Name = "ManageHotels_ClearBtn";
            this.ManageHotels_ClearBtn.Size = new System.Drawing.Size(128, 35);
            this.ManageHotels_ClearBtn.TabIndex = 63;
            this.ManageHotels_ClearBtn.Text = "CLEAR";
            this.ManageHotels_ClearBtn.UseVisualStyleBackColor = false;
            this.ManageHotels_ClearBtn.Click += new System.EventHandler(this.ManageHotels_ClearBtn_Click);
            // 
            // ManageHotels_DeleteBtn
            // 
            this.ManageHotels_DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            this.ManageHotels_DeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ManageHotels_DeleteBtn.Location = new System.Drawing.Point(452, 263);
            this.ManageHotels_DeleteBtn.Name = "ManageHotels_DeleteBtn";
            this.ManageHotels_DeleteBtn.Size = new System.Drawing.Size(133, 35);
            this.ManageHotels_DeleteBtn.TabIndex = 62;
            this.ManageHotels_DeleteBtn.Text = "DELETE";
            this.ManageHotels_DeleteBtn.UseVisualStyleBackColor = false;
            this.ManageHotels_DeleteBtn.Click += new System.EventHandler(this.ManageHotels_DeleteBtn_Click);
            // 
            // ManageHotels_UpdateBtn
            // 
            this.ManageHotels_UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            this.ManageHotels_UpdateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ManageHotels_UpdateBtn.Location = new System.Drawing.Point(603, 214);
            this.ManageHotels_UpdateBtn.Name = "ManageHotels_UpdateBtn";
            this.ManageHotels_UpdateBtn.Size = new System.Drawing.Size(128, 35);
            this.ManageHotels_UpdateBtn.TabIndex = 61;
            this.ManageHotels_UpdateBtn.Text = "UPDATE";
            this.ManageHotels_UpdateBtn.UseVisualStyleBackColor = false;
            this.ManageHotels_UpdateBtn.Click += new System.EventHandler(this.ManageHotels_UpdateBtn_Click);
            // 
            // ManageHotels_AddBtn
            // 
            this.ManageHotels_AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            this.ManageHotels_AddBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ManageHotels_AddBtn.Location = new System.Drawing.Point(450, 214);
            this.ManageHotels_AddBtn.Name = "ManageHotels_AddBtn";
            this.ManageHotels_AddBtn.Size = new System.Drawing.Size(135, 35);
            this.ManageHotels_AddBtn.TabIndex = 60;
            this.ManageHotels_AddBtn.Text = "ADD";
            this.ManageHotels_AddBtn.UseVisualStyleBackColor = false;
            this.ManageHotels_AddBtn.Click += new System.EventHandler(this.ManageHotels_AddBtn_Click);
            // 
            // ManageHotels_Picture
            // 
            this.ManageHotels_Picture.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ManageHotels_Picture.Location = new System.Drawing.Point(552, 304);
            this.ManageHotels_Picture.Name = "ManageHotels_Picture";
            this.ManageHotels_Picture.Size = new System.Drawing.Size(173, 99);
            this.ManageHotels_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ManageHotels_Picture.TabIndex = 59;
            this.ManageHotels_Picture.TabStop = false;
            // 
            // ManageHotels_Package
            // 
            this.ManageHotels_Package.FormattingEnabled = true;
            this.ManageHotels_Package.Items.AddRange(new object[] {
            "Economy",
            "Business",
            "First-Class"});
            this.ManageHotels_Package.Location = new System.Drawing.Point(540, 171);
            this.ManageHotels_Package.Name = "ManageHotels_Package";
            this.ManageHotels_Package.Size = new System.Drawing.Size(188, 28);
            this.ManageHotels_Package.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(463, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 72;
            this.label4.Text = "Package:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(488, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 71;
            this.label3.Text = "Cost:";
            // 
            // ManageHotels_Cost
            // 
            this.ManageHotels_Cost.Location = new System.Drawing.Point(540, 127);
            this.ManageHotels_Cost.Name = "ManageHotels_Cost";
            this.ManageHotels_Cost.Size = new System.Drawing.Size(188, 26);
            this.ManageHotels_Cost.TabIndex = 70;
            // 
            // ManageHotels_City
            // 
            this.ManageHotels_City.FormattingEnabled = true;
            this.ManageHotels_City.Items.AddRange(new object[] {
            "Dhaka",
            "Chittagong",
            "Sylhet",
            "Rajshahi",
            "Rangpur",
            "Mymensingh",
            "Barisal",
            "Khulna"});
            this.ManageHotels_City.Location = new System.Drawing.Point(540, 80);
            this.ManageHotels_City.Name = "ManageHotels_City";
            this.ManageHotels_City.Size = new System.Drawing.Size(188, 28);
            this.ManageHotels_City.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(495, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "City:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(441, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Hotel Name:";
            // 
            // ManageHotels_HotelName
            // 
            this.ManageHotels_HotelName.Location = new System.Drawing.Point(540, 37);
            this.ManageHotels_HotelName.Name = "ManageHotels_HotelName";
            this.ManageHotels_HotelName.Size = new System.Drawing.Size(188, 26);
            this.ManageHotels_HotelName.TabIndex = 66;
            // 
            // ManageHotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ManageHotels_Package);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ManageHotels_Cost);
            this.Controls.Add(this.ManageHotels_City);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ManageHotels_HotelName);
            this.Controls.Add(this.ManageHotels_PicUploadBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ManageHotels_ClearBtn);
            this.Controls.Add(this.ManageHotels_DeleteBtn);
            this.Controls.Add(this.ManageHotels_UpdateBtn);
            this.Controls.Add(this.ManageHotels_AddBtn);
            this.Controls.Add(this.ManageHotels_Picture);
            this.Name = "ManageHotelForm";
            this.Size = new System.Drawing.Size(750, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageHotels_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ManageHotels_PicUploadBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ManageHotels_ClearBtn;
        private System.Windows.Forms.Button ManageHotels_DeleteBtn;
        private System.Windows.Forms.Button ManageHotels_UpdateBtn;
        private System.Windows.Forms.Button ManageHotels_AddBtn;
        private System.Windows.Forms.PictureBox ManageHotels_Picture;
        private System.Windows.Forms.ComboBox ManageHotels_Package;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ManageHotels_Cost;
        private System.Windows.Forms.ComboBox ManageHotels_City;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ManageHotels_HotelName;
    }
}
