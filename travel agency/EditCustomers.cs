using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using travel_agency.data;
using travel_agency.managers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace travel_agency
{
    public partial class EditCustomers : Form
    {
        public EditCustomers(string id)
        {
            InitializeComponent();
            List<Customer> customers = Customers_manager.GetAll();
            List<Country> countries = Country_manager.GetAll();
            Customer specificCustomer = customers.FirstOrDefault(c => c.Id == int.Parse(id));
            Country.DataSource = countries;
            Country.SelectedValue = (specificCustomer.Country_id);

            Firstname.Text = specificCustomer.Firstname;
            Lastname.Text = specificCustomer.Lastname;
            Email.Text = specificCustomer.Email;
            Premium_member.Checked = specificCustomer.Premium_member;

            Id = int.Parse(id);
        }

        public int Id { get; set; }


        private void submit_Click(object sender, EventArgs e)
        {
            Customers_manager.upate(Id, Firstname.Text, Lastname.Text, Email.Text, Premium_member.Checked, Convert.ToInt32(Country.SelectedValue));
            this.Close();
        }

    }
}
