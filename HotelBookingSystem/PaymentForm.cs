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
    public partial class PaymentForm : Form
    {
        private int userId;
        private int bookingId;
        private int payment_amount;
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\HotelBookingSystem.mdf;Integrated Security=True;Connect Timeout=30");
        public PaymentForm(int userId,int bookingId,int payment_amount)
        {
            InitializeComponent();
            this.userId = userId;
            this.bookingId = bookingId;
            this.payment_amount = payment_amount;
            //PaymentForm_PaymentAmount.Text = bookingId.ToString();
            PaymentForm_PaymentAmount.Text = this.payment_amount.ToString();
            
        }
        private void label2_Click(object sender, EventArgs e)
        {
            userMainform hotelbookingportal = new userMainform(userId);
            hotelbookingportal.Show();
            this.Hide();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {

        }

        private void PaymentForm_Confirm_btn_Click(object sender, EventArgs e)
        {
            if (PaymentForm_PaymentMethod.Text == ""
                || PaymentForm_PaymentAmount.Text == ""
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
                        string insertData = "INSERT INTO payments" +
                                "(user_id, booking_id, payment_method, payment_amount, payment_date) " +
                                "VALUES (@User_Id, @Booking_Id, @Payment_Method, @Payment_Amount, @Payment_Date);"; 
                                

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@User_Id", userId);
                            cmd.Parameters.AddWithValue("@Booking_Id", bookingId);
                            cmd.Parameters.AddWithValue("@Payment_Method", PaymentForm_PaymentMethod.Text.Trim());
                            cmd.Parameters.AddWithValue("@Payment_Amount", payment_amount);
                            cmd.Parameters.AddWithValue("@Payment_Date", today);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Payment Sucessfull!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
