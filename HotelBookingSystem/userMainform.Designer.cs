
namespace HotelBookingSystem
{
    partial class userMainform
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.HBP_hotelName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.HBP_hotelid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.HBP_nightCost = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.HBP_location = new System.Windows.Forms.TextBox();
            this.PostAReview_btn = new System.Windows.Forms.Button();
            this.Book_btn = new System.Windows.Forms.Button();
            this.HBP_picture = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HBP_package = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HBP_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 47);
            this.panel1.TabIndex = 0;
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
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(289, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hotel Booking Portal";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(352, 379);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(390, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Hotel Name:";
            // 
            // HBP_hotelName
            // 
            this.HBP_hotelName.Location = new System.Drawing.Point(493, 117);
            this.HBP_hotelName.Name = "HBP_hotelName";
            this.HBP_hotelName.Size = new System.Drawing.Size(120, 26);
            this.HBP_hotelName.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(415, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 45;
            this.label9.Text = "Hotel ID:";
            // 
            // HBP_hotelid
            // 
            this.HBP_hotelid.Location = new System.Drawing.Point(493, 70);
            this.HBP_hotelid.Name = "HBP_hotelid";
            this.HBP_hotelid.Size = new System.Drawing.Size(120, 26);
            this.HBP_hotelid.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(400, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 51;
            this.label10.Text = "Night Cost:";
            // 
            // HBP_nightCost
            // 
            this.HBP_nightCost.Location = new System.Drawing.Point(493, 206);
            this.HBP_nightCost.Name = "HBP_nightCost";
            this.HBP_nightCost.Size = new System.Drawing.Size(120, 26);
            this.HBP_nightCost.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(413, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 20);
            this.label11.TabIndex = 49;
            this.label11.Text = "Location:";
            // 
            // HBP_location
            // 
            this.HBP_location.Location = new System.Drawing.Point(493, 159);
            this.HBP_location.Name = "HBP_location";
            this.HBP_location.Size = new System.Drawing.Size(120, 26);
            this.HBP_location.TabIndex = 48;
            // 
            // PostAReview_btn
            // 
            this.PostAReview_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            this.PostAReview_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PostAReview_btn.Location = new System.Drawing.Point(637, 304);
            this.PostAReview_btn.Name = "PostAReview_btn";
            this.PostAReview_btn.Size = new System.Drawing.Size(205, 34);
            this.PostAReview_btn.TabIndex = 53;
            this.PostAReview_btn.Text = "Post a Review";
            this.PostAReview_btn.UseVisualStyleBackColor = false;
            this.PostAReview_btn.Click += new System.EventHandler(this.PostAReview_btn_Click);
            // 
            // Book_btn
            // 
            this.Book_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            this.Book_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Book_btn.Location = new System.Drawing.Point(493, 304);
            this.Book_btn.Name = "Book_btn";
            this.Book_btn.Size = new System.Drawing.Size(120, 34);
            this.Book_btn.TabIndex = 54;
            this.Book_btn.Text = "Book";
            this.Book_btn.UseVisualStyleBackColor = false;
            this.Book_btn.Click += new System.EventHandler(this.Book_btn_Click);
            // 
            // HBP_picture
            // 
            this.HBP_picture.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.HBP_picture.Location = new System.Drawing.Point(637, 73);
            this.HBP_picture.Name = "HBP_picture";
            this.HBP_picture.Size = new System.Drawing.Size(205, 156);
            this.HBP_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HBP_picture.TabIndex = 55;
            this.HBP_picture.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Package:";
            // 
            // HBP_package
            // 
            this.HBP_package.Location = new System.Drawing.Point(493, 255);
            this.HBP_package.Name = "HBP_package";
            this.HBP_package.Size = new System.Drawing.Size(120, 26);
            this.HBP_package.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 26);
            this.label3.TabIndex = 58;
            this.label3.Text = "Click and Select from this box";
            // 
            // userMainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 489);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HBP_package);
            this.Controls.Add(this.HBP_picture);
            this.Controls.Add(this.Book_btn);
            this.Controls.Add(this.PostAReview_btn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.HBP_nightCost);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.HBP_location);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.HBP_hotelName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.HBP_hotelid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userMainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "userMainform";
            this.Load += new System.EventHandler(this.userMainform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HBP_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox HBP_hotelName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox HBP_hotelid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox HBP_nightCost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox HBP_location;
        private System.Windows.Forms.Button PostAReview_btn;
        private System.Windows.Forms.Button Book_btn;
        private System.Windows.Forms.PictureBox HBP_picture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HBP_package;
        private System.Windows.Forms.Label label3;
    }
}