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
using System.Windows.Forms;

namespace HotelBookingSystem
{
    public partial class AdminRegister : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\HotelBookingSystem.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminRegister()
        {
            InitializeComponent();
        }

        private void adminregister_to_login_Click(object sender, EventArgs e)
        {
            AdminLogin adminLoginForm = new AdminLogin();
            adminLoginForm.Show();
            this.Hide();
        }

        private void adminregister_checkpass_CheckedChanged(object sender, EventArgs e)
        {
            adminRegister_password.PasswordChar = adminregister_checkpass.Checked ? '\0' : '*';
        }

        private void AdminRegister_loginbtn_Click(object sender, EventArgs e)
        {
            string security_code = "5555";
            if (adminRegister_username.Text == ""
                || adminRegister_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(adminRegister_securityCode.Text != security_code)
            {
                MessageBox.Show("Security Code not matched!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        string selectUsername = "SELECT COUNT(id) FROM users WHERE username = @user";

                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@user", adminRegister_username.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar();
                            if (count >= 1)
                            {
                                MessageBox.Show(adminRegister_username.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                string typeofuser = "admin";
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO users" +
                                    "(username,password,userType,date_register) " +
                                    "VALUES(@username,@password,@usertype,@dateReg)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", adminRegister_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", adminRegister_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@usertype", typeofuser);
                                    cmd.Parameters.AddWithValue("@dateReg", today);


                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    AdminLogin adminloginForm = new AdminLogin();
                                    adminloginForm.Show();
                                    this.Hide();
                                }
                            }
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
