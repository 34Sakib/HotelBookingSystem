using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace HotelBookingSystem
{
    public partial class ReviewHotel : Form
    {
        private int userId;
        private int hotelId;
        
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\HotelBookingSystem.mdf;Integrated Security=True;Connect Timeout=30");
        public ReviewHotel(int userId, int hotelId)
        {
            this.userId = userId;
            this.hotelId = hotelId;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            userMainform hotelbookingportal = new userMainform(userId);
            hotelbookingportal.Show();
            this.Hide();
        }

        private void ReviewForm_SubmitReviewbtn_Click(object sender, EventArgs e)
        {
            if (ReviewForm_Rating.Text == ""
                || ReviewForm_ReviewText.Text == ""
                )
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;
                        string insertData = "INSERT INTO reviews" +
                                "(user_id, hotel_id, rating, comment, review_date) " +
                                "VALUES (@User_Id, @Hotel_Id, @Rating, @Comment, @Review_Date);";


                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@User_Id", userId);
                            cmd.Parameters.AddWithValue("@Hotel_Id", hotelId);
                            cmd.Parameters.AddWithValue("@Rating", ReviewForm_Rating.Text.Trim());
                            cmd.Parameters.AddWithValue("@comment", ReviewForm_ReviewText.Text.Trim());
                            cmd.Parameters.AddWithValue("@Review_Date", today);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Review Submitted Sucessfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            userMainform hotelbookingportal = new userMainform(userId);
                            hotelbookingportal.Show();
                            this.Hide();
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
    }
}
