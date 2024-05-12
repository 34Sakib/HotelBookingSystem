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
    public partial class AdminLogin : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\HotelBookingSystem.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void adminlogin_checkpass_CheckedChanged(object sender, EventArgs e)
        {
            adminlogin_password.PasswordChar = adminlogin_checkpass.Checked ? '\0' : '*';
        }

        private void adminlogin_to_resister_Click(object sender, EventArgs e)
        {
            AdminRegister adminregForm = new AdminRegister();
            adminregForm.Show();
            this.Hide();
        }

        private void adminlogin_To_Userlogin_Click(object sender, EventArgs e)
        {
            Form1 LoginForm = new Form1();
            LoginForm.Show();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Adminlogin_loginbtn_Click(object sender, EventArgs e)
        {
            if (adminlogin_username.Text == ""
                    || adminlogin_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        string typeofuser = "admin";
                        connect.Open();
                        string selectData = "SELECT * FROM users WHERE username = @username " +
                            "AND password = @password AND userType = @usertype ";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", adminlogin_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", adminlogin_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@usertype", typeofuser);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Login Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                AdminDashboard admindashboard1 = new AdminDashboard();
                                admindashboard1.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }


                        }
                    }
                    catch (Exception ex)
                    {

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
