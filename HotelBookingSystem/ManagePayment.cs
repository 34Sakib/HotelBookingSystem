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
    public partial class ManagePayment : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\HotelBookingSystem.mdf;Integrated Security=True;Connect Timeout=30");
        public ManagePayment()
        {
            InitializeComponent();
            displayPaymentData();
        }

        public void displayPaymentData()
        {

            PaymentData pd = new PaymentData();
            List<PaymentData> listdata = pd.PaymentListData();

            dataGridView1.DataSource = listdata;
        }
        public void clearFields()
        {
            ManagePayments_PaymentId.Text = "";
            ManagePayments_UserId.Text = "";
            ManagePayments_PaymentMethod.Text = "";
            ManagePayments_PaymentAmount.Text = "";
        }
        private void ManagePayment_Load(object sender, EventArgs e)
        {

        }

        private void ManageHotels_ClearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void ManageHotels_DeleteBtn_Click(object sender, EventArgs e)
        {
            if (ManagePayments_PaymentId.Text == ""
                || ManagePayments_UserId.Text == ""
                || ManagePayments_PaymentMethod.Text == ""
                || ManagePayments_PaymentAmount.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string paymentId = ManagePayments_PaymentId.Text.Trim();
                DialogResult check = MessageBox.Show("Are you sure you want to delete payment with ID: " + paymentId + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        string deleteData = "DELETE FROM payments WHERE payment_id = @Payment_ID";

                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {
                            cmd.Parameters.AddWithValue("@Payment_ID", paymentId);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User with ID " + paymentId + " deleted successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayPaymentData();
                                clearFields();
                            }
                            else
                            {
                                MessageBox.Show("No user found with ID " + paymentId, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                ManagePayments_PaymentId.Text = row.Cells[0].Value.ToString();
                ManagePayments_UserId.Text = row.Cells[1].Value.ToString();
                //ManageHotels_HotelName.Text = ManageHotels_ID;
                ManagePayments_PaymentMethod.Text = row.Cells[3].Value.ToString();
                ManagePayments_PaymentAmount.Text = row.Cells[4].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManagePayments_UserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManagePayments_PaymentAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ManagePayments_PaymentMethod_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ManagePayments_PaymentId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
