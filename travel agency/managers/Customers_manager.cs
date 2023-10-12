using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace travel_agency
{
    public class Customers_manager
    {
        public static List<Customer> GetAll()
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=mydb;Uid=root;Pwd=;");
            con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT customer.id, firstname, lastname, email, premium_member, country.name as country, country.id as country_id FROM customer JOIN country ON customer.country_id = country.id", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                List<Customer> result = new List<Customer>();
                while (reader.Read())
                {
                    int id = (int)reader["id"];
                    string firstname = reader["firstname"].ToString();
                    string lastname = reader["lastname"].ToString();
                    string email = reader["email"].ToString();
                    bool premiumMember = (bool)reader["premium_member"];
                    string country = reader["country"].ToString();
                    int country_id = (int)reader["country_id"];

                    result.Add(new Customer(id, firstname, lastname, email, premiumMember, country, country_id));
                }
                reader.Close(); // Close the reader when you're done with it.
                return result;


            }
            finally
            {
                con.Close();
            }

        }
        public static void upate(int aId, string aFirstname, string aLastname, string aEmail, bool aPremiummember, int aCountry_id)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=mydb;Uid=root;Pwd=;");
            con.Open();
            try
            {
                MySqlCommand command = new MySqlCommand("UPDATE customer SET firstname = @firstname, lastname = @lastname, email = @email, premium_member = @premium_member, country_id = @country_id WHERE id = @id", con);
                command.Parameters.Add(new MySqlParameter("@firstname", aFirstname));
                command.Parameters.Add(new MySqlParameter("@lastname", aLastname));
                command.Parameters.Add(new MySqlParameter("@email", aEmail));
                command.Parameters.Add(new MySqlParameter("@premium_member", aPremiummember));
                command.Parameters.Add(new MySqlParameter("@country_id", aCountry_id));
                command.Parameters.Add(new MySqlParameter("@id", aId));

                command.ExecuteNonQuery();

            }
            finally
            {
                con.Close();
            }
        }

        public static void add(string firstName, string lastName, string email, bool isPremiumMember, int countryId)
        {
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=mydb;Uid=root;Pwd=;");
            con.Open();
            try
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO customer (firstname, lastname, email, premium_member, country_id) VALUES (@firstname, @lastname, @email, @premium_member, @country_id)", con);
                command.Parameters.Add(new MySqlParameter("@firstname", firstName));
                command.Parameters.Add(new MySqlParameter("@lastname", lastName));
                command.Parameters.Add(new MySqlParameter("@email", email));
                command.Parameters.Add(new MySqlParameter("@premium_member", isPremiumMember));
                command.Parameters.Add(new MySqlParameter("@country_id", countryId));

                command.ExecuteNonQuery();

            }
            finally
            {
                con.Close();
            }
        }


    }
}
