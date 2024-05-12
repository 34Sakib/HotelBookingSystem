using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelBookingSystem
{
    public partial class Register : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\HotelBookingSystem.mdf;Integrated Security=True;Connect Timeout=30");

        public Register()
        {
            InitializeComponent();
        }

        private void registerform_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_to_Login_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void register_registerbtn_Click(object sender, EventArgs e)
        {
            if (register_username.Text == ""
                || register_password.Text == "")
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

                        string selectUsername = "SELECT COUNT(id) FROM users WHERE username = @user";
                        
                        using(SqlCommand checkUser= new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@user", register_username.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar();
                            if (count >= 1)
                            {
                                MessageBox.Show(register_username.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                string typeofuser = "user";
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO users" +
                                    "(username,phone,email,password,userType,date_register) " +
                                    "VALUES(@username,@phone,@email,@password,@usertype,@dateReg)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", register_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@phone", register_phone.Text.Trim());
                                    cmd.Parameters.AddWithValue("@email", register_email.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", register_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@usertype", typeofuser);
                                    cmd.Parameters.AddWithValue("@dateReg", today);
                                    

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 loginForm = new Form1();
                                    loginForm.Show();
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

        private void register_checkpass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_checkpass.Checked ? '\0' : '*';
        }
    }
}
