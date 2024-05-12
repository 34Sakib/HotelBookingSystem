
namespace HotelBookingSystem
{
    partial class ReviewHotel
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
            this.ReviewForm_SubmitReviewbtn = new System.Windows.Forms.Button();
            this.ReviewForm_Rating = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ReviewForm_ReviewText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Review = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReviewForm_SubmitReviewbtn
            // 
            this.ReviewForm_SubmitReviewbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            this.ReviewForm_SubmitReviewbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReviewForm_SubmitReviewbtn.Location = new System.Drawing.Point(76, 382);
            this.ReviewForm_SubmitReviewbtn.Name = "ReviewForm_SubmitReviewbtn";
            this.ReviewForm_SubmitReviewbtn.Size = new System.Drawing.Size(202, 46);
            this.ReviewForm_SubmitReviewbtn.TabIndex = 63;
            this.ReviewForm_SubmitReviewbtn.Text = "Submit Review";
            this.ReviewForm_SubmitReviewbtn.UseVisualStyleBackColor = false;
            this.ReviewForm_SubmitReviewbtn.Click += new System.EventHandler(this.ReviewForm_SubmitReviewbtn_Click);
            // 
            // ReviewForm_Rating
            // 
            this.ReviewForm_Rating.FormattingEnabled = true;
            this.ReviewForm_Rating.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.ReviewForm_Rating.Location = new System.Drawing.Point(18, 136);
            this.ReviewForm_Rating.Name = "ReviewForm_Rating";
            this.ReviewForm_Rating.Size = new System.Drawing.Size(115, 28);
            this.ReviewForm_Rating.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "Write about your experience:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 60;
            this.label9.Text = "Rate this Hotel:";
            // 
            // ReviewForm_ReviewText
            // 
            this.ReviewForm_ReviewText.Location = new System.Drawing.Point(18, 225);
            this.ReviewForm_ReviewText.Multiline = true;
            this.ReviewForm_ReviewText.Name = "ReviewForm_ReviewText";
            this.ReviewForm_ReviewText.Size = new System.Drawing.Size(311, 141);
            this.ReviewForm_ReviewText.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(310, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 36);
            this.label2.TabIndex = 58;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Review
            // 
            this.Review.AutoSize = true;
            this.Review.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            this.Review.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Review.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Review.Location = new System.Drawing.Point(127, 15);
            this.Review.Name = "Review";
            this.Review.Size = new System.Drawing.Size(99, 29);
            this.Review.TabIndex = 57;
            this.Review.Text = "Review";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(197)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 61);
            this.panel1.TabIndex = 56;
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
            // ReviewHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Controls.Add(this.ReviewForm_SubmitReviewbtn);
            this.Controls.Add(this.ReviewForm_Rating);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ReviewForm_ReviewText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Review);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReviewHotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReviewHotel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReviewForm_SubmitReviewbtn;
        private System.Windows.Forms.ComboBox ReviewForm_Rating;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ReviewForm_ReviewText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Review;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
    }
}