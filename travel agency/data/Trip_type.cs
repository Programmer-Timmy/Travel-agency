using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travel_agency.data
{
    internal class Trip_type
    {
        public Trip_type(int aId, string aName)
        {
            Id = aId;
            Name = aName;
            ;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
