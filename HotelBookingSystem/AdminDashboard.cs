using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingSystem
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminDashboard_ManageHotelsBtn_Click(object sender, EventArgs e)
        {
            manageHotelForm1.Visible = true;
            manageUsersForm2.Visible = false;
            managePayment3.Visible = false;
            manageReview2.Visible = false;
            overview1.Visible = false;

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminDashboard_ManageUsersBtn_Click(object sender, EventArgs e)
        {
            manageHotelForm1.Visible = false;
            manageUsersForm2.Visible = true;
            managePayment3.Visible = false;
            manageReview2.Visible = false;
            overview1.Visible = false;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
           
        }

        private void AdminDashboard_ManagePaymentsBtn_Click(object sender, EventArgs e)
        {
            manageHotelForm1.Visible = false;
            manageUsersForm2.Visible = false;
            managePayment3.Visible = true;
            manageReview2.Visible = false;
            overview1.Visible = false;
        }

        private void AdminDashboard_ManageReviewsBtn_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashboard_ManageReviewsBtn_Click_1(object sender, EventArgs e)
        {
            manageHotelForm1.Visible = false;
            manageUsersForm2.Visible = false;
            managePayment3.Visible = false;
            manageReview2.Visible = true;
            overview1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            manageHotelForm1.Visible = false;
            manageUsersForm2.Visible = false;
            managePayment3.Visible = false;
            manageReview2.Visible = false;
            overview1.Visible = true;
        }
    }
}
