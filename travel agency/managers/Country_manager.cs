using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using travel_agency.data;

namespace travel_agency.managers
{
    internal class Country_manager
    {
        public static List<Country> GetAll()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=mydb;Uid=root;Pwd=;");
            con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT id, name FROM `country` ", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                List<Country> result = new List<Country>();
                while (reader.Read())
                {
                    int id = (int)reader["id"];
                    string name = reader["name"].ToString();


                    // Create a new Booking object with the retrieved data
                    Country country = new Country(id, name);

                    result.Add(country);
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
