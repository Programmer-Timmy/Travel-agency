using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travel_agency
{
    internal class Trip
    {
        public Trip(int aId, string aDestination, DateTime aTravel_date, int aDuration_days, int aMin_travelers, int aMax_travelers, string aCountry, string aTrip_type, string aIntensity, int aCountry_id, int aTrip_type_id, int aIntensety_id)
        {
            Id = aId;
            Destination = aDestination;
            Travel_date = aTravel_date;
            Duration_days = aDuration_days;
            Min_travelers = aMin_travelers;
            Max_travelers = aMax_travelers;
            Country = aCountry;
            Trip_type = aTrip_type;
            Intensity = aIntensity;
            Country_id = aCountry_id;
            Trip_type_id = aTrip_type_id;
            Intensity_id = aIntensety_id;
        }

        public int Id { get; set; }
        public string Destination { get; set; }
        public DateTime Travel_date { get; set; }
        public int Duration_days { get; set; }
        public int Min_travelers { get; set; }
        public int Max_travelers { get; set; }
        public string Country { get; set; }
        public string Trip_type { get; set; }
        public string Intensity { get; set; }
        public int Country_id { get; set; }
        public int Trip_type_id { get; set; }
        public int Intensity_id { get; set; }
    }
}
