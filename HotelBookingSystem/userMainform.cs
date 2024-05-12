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
    public partial class userMainform : Form
    {
        private int userId;
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\HotelBookingSystem.mdf;Integrated Security=True;Connect Timeout=30");
        public userMainform(int userId)
        {
            InitializeComponent();
            displayHotelData();
            this.userId = userId;
            
        }

        public void displayHotelData()
        {

            HotelData hd = new HotelData();
            List<HotelData> listdata = hd.hotelListData();

            dataGridView1.DataSource = listdata;


        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void PostAReview_btn_Click(object sender, EventArgs e)
        {
            if (HBP_hotelid.Text == ""
                || HBP_hotelName.Text == ""
                || HBP_location.Text == ""
                || HBP_nightCost.Text == ""
                || HBP_package.Text == ""
                || HBP_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int hotelId = Convert.ToInt32(HBP_hotelid.Text);
                ReviewHotel reviewForm1 = new ReviewHotel(userId,hotelId);
                reviewForm1.Show();
                this.Hide();
            }

                
        }

        private void userMainform_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void Book_btn_Click(object sender, EventArgs e)
        {
            if (HBP_hotelid.Text == ""
                || HBP_hotelName.Text == ""
                || HBP_location.Text == ""
                || HBP_nightCost.Text == ""
                || HBP_package.Text == ""
                || HBP_picture.Image == null)
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
                        string insertData = "INSERT INTO bookings" +
                                "(user_id, hotel_id, check_in_date) " +
                                "VALUES (@User_Id, @Hotel_Id, @Check_In_Date);" +
                                "SELECT SCOPE_IDENTITY();";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@User_Id", userId);
                            cmd.Parameters.AddWithValue("@Hotel_Id", HBP_hotelid.Text.Trim());
                            cmd.Parameters.AddWithValue("@Check_In_Date", today);


      

                            int bookingId = Convert.ToInt32(cmd.ExecuteScalar());
                            int payment_amount = Convert.ToInt32(HBP_nightCost.Text);

                            //MessageBox.Show("Registered Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            PaymentForm paymentForm1 = new PaymentForm(userId,bookingId,payment_amount);
                            paymentForm1.Show();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                HBP_hotelid.Text = row.Cells[0].Value.ToString();
                HBP_hotelName.Text = row.Cells[1].Value.ToString();
                //ManageHotels_HotelName.Text = ManageHotels_ID;
                HBP_location.Text = row.Cells[2].Value.ToString();
                HBP_nightCost.Text = row.Cells[3].Value.ToString();
                HBP_package.Text = row.Cells[4].Value.ToString();

                string imagePath = row.Cells[5].Value.ToString();

                if (imagePath != null)
                {
                    HBP_picture.Image = Image.FromFile(imagePath);
                }
                else
                {
                   HBP_picture.Image = null;
                }

            }

        }
    }
}
