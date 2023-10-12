using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using travel_agency.managers;

namespace travel_agency
{
    public partial class Form1 : Form
    {
        public string selected_id { get; set; }
        private string curent_tabel;

        public Form1()
        {
            InitializeComponent();
        }


        private void Show_Customers_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            List<Customer> customer = Customers_manager.GetAll();
            dataGridView1.DataSource = customer;
            dataGridView1.Columns["country_id"].Visible = false;
            Edit.Text = "Edit";
            Delete.Text = "Delete";
            curent_tabel = "Customer";
            Add.Text = "Add " + curent_tabel;
            selected_id = null;
        }

        private void Shows_Trips_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            List<Trip> trip = Trip_manager.GetAll();
            dataGridView1.DataSource = trip;
            dataGridView1.Columns["country_id"].Visible = false;
            dataGridView1.Columns["trip_type_id"].Visible = false;
            dataGridView1.Columns["intensity_id"].Visible = false;
            Edit.Text = "Edit";
            Delete.Text = "Delete";
            curent_tabel = "Trip";
            Add.Text = "Add " + curent_tabel;
            selected_id = null;
        }

        private void Show_Bookings_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            List<Booking> booking = Booking_manager.GetAll();
            dataGridView1.DataSource = booking;
            dataGridView1.Columns["tripid"].Visible = false;
            dataGridView1.Columns["customerid"].Visible = false;
            curent_tabel = "Booking";
            Edit.Text = "Edit";
            Delete.Text = "Delete";
            Add.Text = "Add " + curent_tabel;
            selected_id = null;


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selected_row = e.RowIndex;
            var row = dataGridView1.Rows[selected_row];

            selected_id = row.Cells[0].Value.ToString();
            Edit.Text = "Edit " + curent_tabel + ": "+ selected_id;
            Delete.Text = "Delete " + curent_tabel + ": " + selected_id;
            
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (curent_tabel == null) { MessageBox.Show("Pls select a tabel firts"); return; } 
            if (selected_id == null) { MessageBox.Show("Pls first select a row"); return; }
            if (curent_tabel == "Customer")
            {
                var myForm = new EditCustomers(selected_id);
                myForm.Show();
                List<Customer> customer = Customers_manager.GetAll();
                dataGridView1.DataSource = customer;

            }
            else if(curent_tabel == "Trip")
            {
                var myForm = new EditTrip(selected_id);
                myForm.Show();
                List<Trip> trip = Trip_manager.GetAll();
                dataGridView1.DataSource = trip;
            }
            else if(curent_tabel == "Booking")
            {
                var myForm = new editBooking(selected_id);
                myForm.Show();
                List<Booking> booking = Booking_manager.GetAll();
                dataGridView1.DataSource = booking;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (curent_tabel == null) { MessageBox.Show("Pls select a tabel firts"); return; }
            if (selected_id == null) { MessageBox.Show("Pls first select a row"); return; }
            if (curent_tabel == "Customer")
            {
                delete(int.Parse(selected_id), "booking", "customer_id");
                delete(int.Parse(selected_id), "customer", "id");
                List<Customer> customer = Customers_manager.GetAll();
                dataGridView1.DataSource = customer;

            }
            else if (curent_tabel == "Trip")
            {
                delete(int.Parse(selected_id), "trip", "id");
                List<Trip> trip = Trip_manager.GetAll();
                dataGridView1.DataSource = trip;


            }
            else if (curent_tabel == "Booking")
            {
                delete(int.Parse(selected_id), "booking", "id");
                List<Booking> booking = Booking_manager.GetAll();
                dataGridView1.DataSource = booking;


            }
        }
        
        public static void delete(int aId, string aTabel, string aWhere)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=mydb;Uid=root;Pwd=;");
            con.Open();
            try
            {
                MySqlCommand command = new MySqlCommand($"DELETE FROM {aTabel} WHERE {aWhere} = @id", con);
                command.Parameters.Add(new MySqlParameter("@id", aId));

                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Pls edit/remove all the conected data in Bookings");
            }
            finally
            {
                con.Close();
            }
            
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (curent_tabel == null) { MessageBox.Show("Pls select a tabel firts"); return; }
            if (curent_tabel == "Customer")
            {
                var myForm = new addCustomers();
                myForm.Show();
            }
            else if (curent_tabel == "Trip")
            {
                var myForm = new addTrip();
                myForm.Show();
            }
            else if (curent_tabel == "Booking")
            {
                var myForm = new addBooking();
                myForm.Show();
            }
        }
    }
}
