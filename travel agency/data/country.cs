using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travel_agency.data
{
    internal class Country
    {
        public Country(int aId, string aName)
        {
            Id = aId;
            Name = aName;
;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
