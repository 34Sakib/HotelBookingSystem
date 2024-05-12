using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HotelBookingSystem
{
    class PaymentData
    {
        public int Payment_ID { set; get; }
        public string User_ID { set; get; } //1
        public string Booking_ID { set; get; } //2
        public string Payment_Method { set; get; } //3
        public string Payment_Amount { set; get; } //4



        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\HotelBookingSystem.mdf;Integrated Security=True;Connect Timeout=30");



        public List<PaymentData> PaymentListData()
        {
            List<PaymentData> listdata = new List<PaymentData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {

                    connect.Open();

                    //string selectData = "SELECT * FROM users";
                    string selectData = "SELECT * FROM payments";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            PaymentData pd = new PaymentData();
                            pd.Payment_ID = (int)reader["payment_id"];
                            pd.User_ID = reader["user_id"].ToString();
                            pd.Booking_ID = reader["booking_id"].ToString();
                            pd.Payment_Method = reader["payment_method"].ToString();
                            pd.Payment_Amount = reader["payment_amount"].ToString();
                            listdata.Add(pd);
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



