using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using travel_agency.data;
using travel_agency.managers;

namespace travel_agency
{
    public partial class addTrip : Form
    {
        public addTrip()
        {
            InitializeComponent();
            List<Country> countries = Country_manager.GetAll();
            List<Trip_type> trip_type = Trip_type_manager.GetAll();
            List<Intensity> intensity = Intensity_manager.GetAll();
            Country.DataSource = countries;

            Trip_Type.DataSource = trip_type;

            Intensity.DataSource = intensity;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            Trip_manager.AddTrip(
                Destination.Text,
                Date.Value,
                Convert.ToInt32(Duration_Days.Value),
                Convert.ToInt32(Min_Travelers.Value),
                Convert.ToInt32(Max_travelers.Value),
                Convert.ToInt32(Country.SelectedValue),
                Convert.ToInt32(Trip_Type.SelectedValue),
                Convert.ToInt32(Intensity.SelectedValue)
            );
            this.Close();
        }
    }
}
