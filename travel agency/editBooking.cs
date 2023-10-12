using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using travel_agency.data;
using travel_agency.managers;

namespace travel_agency
{
    public partial class editBooking : Form
    {
        public editBooking(string id)
        {
            InitializeComponent();
            List<Customer> customers = Customers_manager.GetAll();
            List<Trip> trips = Trip_manager.GetAll();
            List<Booking> booking = Booking_manager.GetAll();
            Booking specificBooking = booking.FirstOrDefault(c => c.Id == int.Parse(id));

            Trip.DataSource = trips;
            Trip.SelectedValue = (specificBooking.TripId);

            Customer.DataSource = customers;
            Customer.SelectedValue = (specificBooking.CustomerId);

            Booking_Date.Value = specificBooking.Booking_date;

            Id = int.Parse(id);
        }

        public int Id { get; set; }


        private void submit_Click(object sender, EventArgs e)
        {
            Booking_manager.upate(Id, Convert.ToInt32(Customer.SelectedValue), Convert.ToInt32(Trip.SelectedValue), Booking_Date.Value);
            this.Close();
        }
    }
}
