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
    public partial class addCustomers : Form
    {
        public addCustomers()
        {
            InitializeComponent();
            List<Country> countries = Country_manager.GetAll();
            Country.DataSource = countries;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            Customers_manager.add(Firstname.Text, Lastname.Text, Email.Text, Premium_member.Checked, Convert.ToInt32(Country.SelectedValue));
            this.Close();
        }
    }
}
