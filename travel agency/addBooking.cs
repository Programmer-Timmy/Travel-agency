using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace travel_agency
{
    public partial class addBooking : Form
    {
        public addBooking()
        {
            InitializeComponent();
            List<Customer> customers = Customers_manager.GetAll();
            List<Trip> trips = Trip_manager.GetAll();

            Trip.DataSource = trips;

            Customer.DataSource = customers;

        }

        private void submit_Click(object sender, EventArgs e)
        {
            Booking_manager.add(Convert.ToInt32(Customer.SelectedValue), Convert.ToInt32(Trip.SelectedValue), Booking_Date.Value);
            this.Close();
        }
    }
}
