using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using travel_agency.data;

namespace travel_agency.managers
{
    internal class Trip_type_manager
    {
        public static List<Trip_type> GetAll()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=mydb;Uid=root;Pwd=;");
            con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT id, name FROM `trip_type` ", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                List<Trip_type> result = new List<Trip_type>();
                while (reader.Read())
                {
                    int id = (int)reader["id"];
                    string name = reader["name"].ToString();


                    // Create a new Booking object with the retrieved data
                    Trip_type trip_type = new Trip_type(id, name);

                    result.Add(trip_type);
                }
                reader.Close(); // Close the reader when you're done with it.
                return result;


            }
            finally
            {
                con.Close();
            }
        }
    }
}
