using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travel_agency.data
{
    internal class Intensity
    {
        public Intensity(int aId, string aDescription)
        {
            Id = aId;
            Description = aDescription;
            ;
        }

        public int Id { get; set; }
        public string Description { get; set; }
    }
}
