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
    public partial class ManageUsersForm : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\HotelBookingSystem.mdf;Integrated Security=True;Connect Timeout=30");
        public ManageUsersForm()
        {
            InitializeComponent();
            displayUserData();
        }

        public void displayUserData()
        {

            UserData ud = new UserData();
            List<UserData> listdata = ud.UserListData();

            dataGridView1.DataSource = listdata;
        }
        public void clearFields()
        {
            ManageUsers_UserID.Text = "";
            ManageUsers_UserName.Text = "";
            ManageUsers_Phone.Text = "";
            ManageUsers_Email.Text = "";
        }

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {

        }

        private void ManageUsers_UpdateBtn_Click(object sender, EventArgs e)
        {
            if (ManageUsers_UserName.Text == ""
                || ManageUsers_Phone.Text == ""
                || ManageUsers_Email.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE " +
                    "User Name : " + ManageUsers_UserName.Text.Trim() + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        string updateData = "UPDATE users SET username= @UserName, phone = @Phone, email = @Email " +
                            "WHERE id = @UserID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@UserName", ManageUsers_UserName.Text.Trim());
                            cmd.Parameters.AddWithValue("@Phone", ManageUsers_Phone.Text.Trim());
                            cmd.Parameters.AddWithValue("@Email", ManageUsers_Email.Text.Trim());
                            cmd.Parameters.AddWithValue("UserID", ManageUsers_UserID.Text.Trim());
                            cmd.ExecuteNonQuery();

                            displayUserData();

                            MessageBox.Show("Updated Successfully ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
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
                else
                {
                    MessageBox.Show("Cancelled: ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                ManageUsers_UserID.Text = row.Cells[0].Value.ToString();
                ManageUsers_UserName.Text = row.Cells[1].Value.ToString();
                //ManageHotels_HotelName.Text = ManageHotels_ID;
                ManageUsers_Phone.Text = row.Cells[2].Value.ToString();
                ManageUsers_Email.Text = row.Cells[3].Value.ToString();
               

            }
        }

        private void ManageUsers_ClearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void ManageUsers_DeleteBtn_Click(object sender, EventArgs e)
        {
            if (ManageUsers_UserName.Text == ""
                || ManageUsers_Phone.Text == ""
                || ManageUsers_Email.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string userId = ManageUsers_UserID.Text.Trim();
                DialogResult check = MessageBox.Show("Are you sure you want to delete user with ID: " + userId + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        string deleteData = "DELETE FROM users WHERE id = @UserID";

                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {
                            cmd.Parameters.AddWithValue("@UserID", userId);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User with ID " + userId + " deleted successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayUserData();
                                clearFields();
                            }
                            else
                            {
                                MessageBox.Show("No user found with ID " + userId, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
