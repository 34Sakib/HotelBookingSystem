using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HotelBookingSystem
{
    class HotelData
    {
        public int ID { set; get; }
        public string HotelName { set; get; } //1
        public string City { set; get; } //2
        public string Cost { set; get; } //3
        public string Package { set; get; } //4
        public string Image { set; get; } //5
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\HotelBookingSystem.mdf;Integrated Security=True;Connect Timeout=30");

       
        
        public List<HotelData> hotelListData()
        {
            List<HotelData> listdata = new List<HotelData>();

            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    
                    connect.Open();
                    
                    string selectData = "SELECT * FROM hotels WHERE delete_date IS NULL";

                    using(SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            HotelData hd = new HotelData();
                            hd.ID = (int)reader["id"];
                            hd.HotelName = reader["hotelname"].ToString();
                            hd.City = reader["city"].ToString();
                            hd.Cost = reader["cost"].ToString();
                            hd.Package = reader["package"].ToString();
                            hd.Image = reader["image"].ToString();

                            listdata.Add(hd);
                        }
                    }
                }catch(Exception ex)
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
