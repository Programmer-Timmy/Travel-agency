using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace travel_agency
{
    internal class Booking_manager
    {
        public static List<Booking> GetAll()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=mydb;Uid=root;Pwd=;");
            con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT booking.id, firstname, lastname, trip.destination, date(booking_date) as booking_date, customer_id, trip_id FROM `booking` JOIN customer on booking.customer_id = customer.id JOIN trip on booking.trip_id = trip.id", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                List<Booking> result = new List<Booking>();
                while (reader.Read())
                {
                    int id = (int)reader["id"];
                    string firstname = reader["firstname"].ToString();
                    string lastname = reader["lastname"].ToString();
                    string destination = reader["destination"].ToString();
                    DateTime bookingDate = (DateTime)reader["booking_date"];
                    int customer_id = (int)reader["customer_id"];
                    int trip_id = (int)reader["trip_id"];


                    // Create a new Booking object with the retrieved data
                    Booking booking = new Booking(id, firstname, lastname, destination, bookingDate, customer_id, trip_id);

                    result.Add(booking);
                }
                reader.Close(); // Close the reader when you're done with it.
                return result;


            }
            finally
            {
                con.Close();
            }
        }
        public static void upate(int aId, int aCustomer_id, int aTrip_id, DateTime aBookingdate)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=mydb;Uid=root;Pwd=;");
            con.Open();
            try
            {
                MySqlCommand command = new MySqlCommand("UPDATE booking SET customer_id = @customer_id, trip_id = @trip_id, booking_date = @booking_date WHERE id = @id", con);
                command.Parameters.Add(new MySqlParameter("@customer_id", aCustomer_id));
                command.Parameters.Add(new MySqlParameter("@trip_id", aTrip_id));
                command.Parameters.Add(new MySqlParameter("@booking_date", aBookingdate));
                command.Parameters.Add(new MySqlParameter("@id", aId));

                command.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public static void add(int aCustomer_id, int aTrip_id, DateTime aBookingdate)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=mydb;Uid=root;Pwd=;");
            con.Open();
            try
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO booking (customer_id, trip_id, booking_date) VALUES (@customer_id, @trip_id, @booking_date)", con);
                command.Parameters.Add(new MySqlParameter("@customer_id", aCustomer_id));
                command.Parameters.Add(new MySqlParameter("@trip_id", aTrip_id));
                command.Parameters.Add(new MySqlParameter("@booking_date", aBookingdate));

                command.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
