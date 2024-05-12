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
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\HotelBookingSystem.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginform_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_to_resister_Click(object sender, EventArgs e)
        {
            Register regForm = new Register();
            regForm.Show();
            this.Hide();
        }

        private void login_checkpass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_checkpass.Checked ?'\0' : '*';
        }

        int userId = 0;
        private void login_loginbtn_Click(object sender, EventArgs e)
        {
            if (login_username.Text == ""
                    || login_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State== ConnectionState.Closed)
                {
                    try
                    {
                        string typeofuser = "user";
                        connect.Open();
                        string selectData = "SELECT * FROM users WHERE username = @username " +
                            "AND password = @password AND userType = @usertype ";

                        using(SqlCommand cmd= new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", login_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", login_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@usertype", typeofuser);


                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    userId = Convert.ToInt32(reader["id"]); // Retrieve id value from the database result set
                                                                            // Now you can use the id value as needed
                                }
                                else
                                {
                                    userId = 10;
                                }
                            }

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Login Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                userMainform hotelbookingportal = new userMainform(userId);
                                hotelbookingportal.Show();
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

        private void login_to_adminLogin_Click(object sender, EventArgs e)
        {
            AdminLogin adminLoginForm = new AdminLogin();
            adminLoginForm.Show();
            this.Hide();
        }
    }
}
