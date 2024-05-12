using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HotelBookingSystem
{

    class ReviewData
    {
        public int Review_ID { set; get; }
        public string User_ID { set; get; } //1
        public string Hotel_ID { set; get; } //2
        public string Rating { set; get; } //3
        public string Review { set; get; } //4

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\HotelBookingSystem.mdf;Integrated Security=True;Connect Timeout=30");

        public List<ReviewData> ReviewListData()
        {
            List<ReviewData> listdata = new List<ReviewData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {

                    connect.Open();

                    //string selectData = "SELECT * FROM users";
                    string selectData = "SELECT * FROM reviews";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            ReviewData rd = new ReviewData();
                            rd.Review_ID = (int)reader["review_id"];
                            rd.User_ID = reader["user_id"].ToString();
                            rd.Hotel_ID = reader["hotel_id"].ToString();
                            rd.Rating = reader["rating"].ToString();
                            rd.Review = reader["comment"].ToString();
                            listdata.Add(rd);
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
