using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    public class Contractor
    {
        public uint ID { get; set; }
        public string Name { get; set; }

        private readonly List<string> registeredIDs = new List<string>();
        public IEnumerable<string> RegisteredIDs { get { return this.registeredIDs; } }
        public void AddRegisterdID(string id) { this.registeredIDs.Add(id); }

        public string Street { get; set; }
        public string BuildingNumber { get; set; }
        public string FlatNumber { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
    }
}
