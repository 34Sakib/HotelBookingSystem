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
using System.IO;

namespace HotelBookingSystem
{
    public partial class ManageHotelForm : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\HotelBookingSystem.mdf;Integrated Security=True;Connect Timeout=30");

        public ManageHotelForm()
        {
            InitializeComponent();
            displayHotelData();
        }

 


        public void displayHotelData()
        {
 
            HotelData hd = new HotelData();
            List<HotelData> listdata = hd.hotelListData();

            dataGridView1.DataSource = listdata;
        }
        private void ManageHotels_AddBtn_Click(object sender, EventArgs e)
        {
            if(ManageHotels_City.Text == ""
                || ManageHotels_Cost.Text == ""
                || ManageHotels_HotelName.Text == ""
                || ManageHotels_Package.Text == ""
                || ManageHotels_Picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if(connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string checkHtID = "SELECT COUNT(*) FROM hotels WHERE hotelname = @htname AND city = @City AND delete_date IS NULL ";
                        using(SqlCommand checkHt = new SqlCommand(checkHtID, connect))
                        {
                            checkHt.Parameters.AddWithValue("@htname", ManageHotels_HotelName.Text.Trim());
                            checkHt.Parameters.AddWithValue("@City", ManageHotels_City.Text.Trim());
                            int count = (int)checkHt.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(ManageHotels_HotelName.Text.Trim() + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO hotels " +
                                    "(hotelname, city, cost, package, date_register, image) " +
                                    "VALUES(@htname, @City, @Cost, @Package, @dateRegister, @Image)";

                                //string path = Path.Combine(@"C:\Users\hp\Desktop\Hotel Booking Project\HotelBookingSystem\HotelBookingSystem\Directory\"
                                // + ManageHotels_HotelName.Text.Trim() + ".jpg");

                                //string directoryPath = Path.GetDirectoryName(path);

                                //if (!Directory.Exists(directoryPath))
                                //{
                                //    Directory.CreateDirectory(directoryPath);
                                //}

                                //File.Copy(ManageHotels_Picture.ImageLocation, path, true);

                                string path = ManageHotels_Picture.ImageLocation;

                                using(SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@htname", ManageHotels_HotelName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@City", ManageHotels_City.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Cost", ManageHotels_Cost.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Package", ManageHotels_Package.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateRegister", today);
                                    cmd.Parameters.AddWithValue("@Image", path);

                                    cmd.ExecuteNonQuery();

                                    displayHotelData();
                                    MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    clearFields();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void ManageHotels_PicUploadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;.png";
                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    ManageHotels_Picture.ImageLocation = imagePath;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }


            
        }

        public void clearFields()
        {
            ManageHotels_Cost.Text = "";
            ManageHotels_HotelName.Text = "";
            ManageHotels_Package.Text = "";
            ManageHotels_City.Text = "";
        }
        string ManageHotels_ID = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                ManageHotels_ID= row.Cells[0].Value.ToString();
                ManageHotels_HotelName.Text = row.Cells[1].Value.ToString();
                //ManageHotels_HotelName.Text = ManageHotels_ID;
                ManageHotels_City.Text = row.Cells[2].Value.ToString();
                ManageHotels_Cost.Text = row.Cells[3].Value.ToString();
                ManageHotels_Package.Text = row.Cells[4].Value.ToString();

                string imagePath = row.Cells[5].Value.ToString();

                if (imagePath != null)
                {
                    ManageHotels_Picture.Image = Image.FromFile(imagePath);
                }
                else
                {
                    ManageHotels_Picture.Image = null;
                }

            }
        }

        private void ManageHotels_UpdateBtn_Click(object sender, EventArgs e)
        {
            if (ManageHotels_City.Text == ""
                || ManageHotels_Cost.Text == ""
                || ManageHotels_HotelName.Text == ""
                || ManageHotels_Package.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE " +
                    "Hotel Name : " + ManageHotels_HotelName.Text.Trim() + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if( check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        string updateData = "UPDATE hotels SET cost= @Cost, package = @Package " +
                            "WHERE hotelname = @hotelName";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@Cost", ManageHotels_Cost.Text.Trim());
                            cmd.Parameters.AddWithValue("@Package", ManageHotels_Package.Text.Trim());
                            cmd.Parameters.AddWithValue("@hotelName", ManageHotels_HotelName.Text.Trim());
                            cmd.ExecuteNonQuery();

                            displayHotelData();

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
                    MessageBox.Show("Cancelled: " , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            }
            }

        private void ManageHotels_ClearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void ManageHotels_DeleteBtn_Click(object sender, EventArgs e)
        {
            if (ManageHotels_City.Text == ""
                || ManageHotels_Cost.Text == ""
                || ManageHotels_HotelName.Text == ""
                || ManageHotels_Package.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to Delete " +
                    "Hotel Name : " + ManageHotels_HotelName.Text.Trim() + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE hotels SET delete_date = @deleteDate " +
                            "WHERE hotelname = @hotelName";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@deleteDate", today);
                            cmd.Parameters.AddWithValue("@hotelName", ManageHotels_HotelName.Text.Trim());
                            

                            cmd.ExecuteNonQuery();

                            displayHotelData();

                            MessageBox.Show("Deleted Successfully ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void ManageHotel_SearchButton_Click(object sender, EventArgs e)
        {
            displayHotelData();
        }

        
    }
}
