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

namespace travel_agency.managers
{
    public partial class EditTrip : Form
    {
        public EditTrip(string id)
        {
            InitializeComponent();
            List<Trip> trip = Trip_manager.GetAll();
            List<Country> countries = Country_manager.GetAll();
            List<Trip_type> trip_type = Trip_type_manager.GetAll();
            List<Intensity> intensity = Intensity_manager.GetAll();
            Trip specificTrip = trip.FirstOrDefault(c => c.Id == int.Parse(id));
            Country.DataSource = countries;
            Country.SelectedValue = (specificTrip.Country_id);

            Trip_Type.DataSource = trip_type;
            Trip_Type.SelectedValue = (specificTrip.Trip_type_id);

            Intensity.DataSource = intensity;
            Intensity.SelectedValue = (specificTrip.Intensity_id);
            
            Destination.Text = specificTrip.Destination;
            Date.Text = specificTrip.Travel_date.ToString();
            Duration_Days.Value = specificTrip.Duration_days;
            Min_Travelers.Value = specificTrip.Min_travelers;
            Max_travelers.Value = specificTrip.Max_travelers;

            Id = int.Parse(id);
        }

        public int Id { get; set; }

        private void submit_Click(object sender, EventArgs e)
        {
            Trip_manager.update(Id, Destination.Text, Date.Value, Convert.ToInt32(Duration_Days.Value), Convert.ToInt32(Min_Travelers.Value), Convert.ToInt32(Max_travelers.Value), Convert.ToInt32(Country.SelectedValue), Convert.ToInt32(Trip_Type.SelectedValue), Convert.ToInt32(Intensity.SelectedValue));
            this.Close();
        }

    }
}
