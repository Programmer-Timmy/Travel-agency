using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace travel_agency
{
    public class Customer
    {
        public Customer(int aId, string aFirstname, string aLastname, string aEmail, bool aPremium_member, string aCountry, int country_id)
        {
            Id = aId;
            Firstname = aFirstname;
            Lastname = aLastname;
            Email = aEmail;
            Premium_member = aPremium_member;
            Country = aCountry;
            Country_id = country_id;
        }

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public bool Premium_member { get; set; }
        public string Country { get; set; }
        public int Country_id { get; set; }
    }
}
