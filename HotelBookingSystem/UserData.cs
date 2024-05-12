using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HotelBookingSystem
{
    class UserData
    {
        public int ID { set; get; }
        public string UserName { set; get; } //1
        public string Phone { set; get; } //2
        public string Email { set; get; } //3
        public string UserType { set; get; } //4

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\HotelBookingSystem.mdf;Integrated Security=True;Connect Timeout=30");



        public List<UserData> UserListData()
        {
            List<UserData> listdata = new List<UserData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {

                    connect.Open();

                    //string selectData = "SELECT * FROM users";
                    string selectData = "SELECT * FROM users WHERE userType = 'user'";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            UserData ud = new UserData();
                            ud.ID = (int)reader["id"];
                            ud.UserName = reader["username"].ToString();
                            ud.Phone = reader["phone"].ToString();
                            ud.Email = reader["email"].ToString();
                            ud.UserType = reader["userType"].ToString();
                            listdata.Add(ud);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listdata;
        }
    }
}
