using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace HotelBookingSystem
{
    public partial class ManageReview : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\HotelBookingSystem.mdf;Integrated Security=True;Connect Timeout=30");
        public ManageReview()
        {
            InitializeComponent();
            displayReviewData();
        }

        public void displayReviewData()
        {

            ReviewData rd = new ReviewData();
            List<ReviewData> listdata = rd.ReviewListData();

            dataGridView1.DataSource = listdata;
        }


        public void clearFields()
        {
            ManageReviews_ReviewId.Text = "";
            ManageReviews_UserId.Text = "";
            ManageReviews_HotelId.Text = "";
            ManageReviews_Rating.Text = "";
            ManageReviews_Rating.Text = "";
        }
        private void ManageReview_Load(object sender, EventArgs e)
        {
        }

        private void ManageReviews_ClearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                ManageReviews_ReviewId.Text = row.Cells[0].Value.ToString();
                ManageReviews_UserId.Text = row.Cells[1].Value.ToString();
                //ManageHotels_HotelName.Text = ManageHotels_ID;
                ManageReviews_HotelId.Text = row.Cells[2].Value.ToString();
                ManageReviews_Rating.Text = row.Cells[3].Value.ToString();
                ManageReviews_Review.Text = row.Cells[4].Value.ToString();

            }
        }

        private void ManageReviews_DeleteBtn_Click(object sender, EventArgs e)
        {
            if (ManageReviews_ReviewId.Text == ""
                || ManageReviews_UserId.Text == ""
                || ManageReviews_HotelId.Text == ""
                || ManageReviews_Rating.Text == ""
                || ManageReviews_Review.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string reviewId = ManageReviews_ReviewId.Text.Trim();
                DialogResult check = MessageBox.Show("Are you sure you want to delete review with ID: " + reviewId + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        string deleteData = "DELETE FROM reviews WHERE review_id = @Review_ID";

                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {
                            cmd.Parameters.AddWithValue("@Review_ID", reviewId);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Review with ID " + reviewId + " deleted successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayReviewData();
                                clearFields();
                            }
                            else
                            {
                                MessageBox.Show("No user found with ID " + reviewId, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Deletion cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }
    }
}
