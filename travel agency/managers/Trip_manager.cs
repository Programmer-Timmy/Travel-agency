using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace travel_agency
{
    internal class Trip_manager
    {
        public static List<Trip> GetAll()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=mydb;Uid=root;Pwd=;");
            con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT trip.id, destination, DATE(travel_date) as travel_date, duration_days, min_travelers, max_travelers, country.name as country, trip_type.name as trip_type, intensity.description as intensity, country_id, trip_type_id, intensity_id FROM trip JOIN country on trip.country_id = country.id JOIN trip_type on trip.trip_type_id = trip_type.id JOIN intensity on trip.intensity_id = intensity.id;", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                List<Trip> result = new List<Trip>();
                while (reader.Read())
                {
                    int id = (int)reader["id"];
                    string destination = reader["destination"].ToString();
                    DateTime travelDate = ((DateTime)reader["travel_date"]);
                    int durationDays = (int)reader["duration_days"];
                    int minTravelers = (int)reader["min_travelers"];
                    int maxTravelers = (int)reader["max_travelers"];
                    string country = reader["country"].ToString();
                    string tripType = reader["trip_type"].ToString();
                    string intensity = reader["intensity"].ToString();
                    int country_id = (int)reader["country_id"];
                    int TripType_id = (int)reader["trip_type_id"];
                    int Intensity_id = (int)reader["intensity_id"];

                    // Create a new Trip object with the retrieved data
                    Trip trip = new Trip(id, destination, travelDate, durationDays, minTravelers, maxTravelers, country, tripType, intensity, country_id, TripType_id, Intensity_id);

                    result.Add(trip);
                }

                reader.Close(); // Close the reader when you're done with it.
                return result;



            }
            finally
            {
                con.Close();
            }

        }
        public static void update(int aId, string aDestination, DateTime aTravelDate,int aDurationDays, int aMinTravelers, int aMaxTravelers, int aCountry_id, int aTripType_id, int Intensity_id)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=mydb;Uid=root;Pwd=;");
            con.Open();
            try
            {
                MySqlCommand command = new MySqlCommand("UPDATE `trip` SET `destination` = @destination, `travel_date` = @travel_date, `duration_days` = @duration_days, `min_travelers` = @min_travelers, `max_travelers` = @max_travelers, `country_id` = @country_id, `trip_type_id` = @trip_type_id, `intensity_id` = @intensity_id WHERE id = @id", con);

                command.Parameters.Add(new MySqlParameter("@destination", aDestination));
                command.Parameters.Add(new MySqlParameter("@travel_date", aTravelDate));
                command.Parameters.Add(new MySqlParameter("@duration_days", aDurationDays));
                command.Parameters.Add(new MySqlParameter("@min_travelers", aMinTravelers));
                command.Parameters.Add(new MySqlParameter("@max_travelers", aMaxTravelers));
                command.Parameters.Add(new MySqlParameter("@country_id", aCountry_id));
                command.Parameters.Add(new MySqlParameter("@trip_type_id", aTripType_id));
                command.Parameters.Add(new MySqlParameter("@intensity_id", Intensity_id));
                command.Parameters.Add(new MySqlParameter("@id", aId));

                command.ExecuteNonQuery();

            }
            finally
            {
                con.Close();
            }
        }

        public static void AddTrip(string destination, DateTime travelDate, int durationDays, int minTravelers, int maxTravelers, int countryId, int tripTypeId, int intensityId)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=mydb;Uid=root;Pwd=;");
            con.Open();
            try
            {
                string query = "INSERT INTO `trip` (`destination`, `travel_date`, `duration_days`, `min_travelers`, `max_travelers`, `country_id`, `trip_type_id`, `intensity_id`) " +
                            "VALUES (@destination, @travel_date, @duration_days, @min_travelers, @max_travelers, @country_id, @trip_type_id, @intensity_id)";

                MySqlCommand command = new MySqlCommand(query, con);

                command.Parameters.AddWithValue("@destination", destination);
                command.Parameters.AddWithValue("@travel_date", travelDate);
                command.Parameters.AddWithValue("@duration_days", durationDays);
                command.Parameters.AddWithValue("@min_travelers", minTravelers);
                command.Parameters.AddWithValue("@max_travelers", maxTravelers);
                command.Parameters.AddWithValue("@country_id", countryId);
                command.Parameters.AddWithValue("@trip_type_id", tripTypeId);
                command.Parameters.AddWithValue("@intensity_id", intensityId);

                command.ExecuteNonQuery();

            }
            finally
            {
                con.Close();
            }
        }
    }
}
