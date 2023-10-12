using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using travel_agency.data;

namespace travel_agency.managers
{
    internal class Intensity_manager
    {
        public static List<Intensity> GetAll()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=mydb;Uid=root;Pwd=;");
            con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT id, description FROM `intensity` ", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                List<Intensity> result = new List<Intensity>();
                while (reader.Read())
                {
                    int id = (int)reader["id"];
                    string description = reader["description"].ToString();


                    // Create a new Booking object with the retrieved data
                    Intensity intensity = new Intensity(id, description);

                    result.Add(intensity);
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
