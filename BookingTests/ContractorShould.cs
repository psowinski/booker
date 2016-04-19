using Xunit;
using Booking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Tests
{
    public class ContractorShould
    {
        [Fact()]
        public void TrackID()
        {
            var obj = new Contractor();
            obj.ID = 33;
            Assert.Equal<uint>(33, obj.ID);
        }

        [Fact()]
        public void TrackName()
        {
            var obj = new Contractor();
            obj.Name = "name1";
            Assert.Equal("name1", obj.Name);
        }

        [Fact()]
        public void TrackRegisteredIDs()
        {
            var obj = new Contractor();
            obj.AddRegisterdID("id1");
            Assert.Equal("id1", obj.RegisteredIDs.Single());
        }

        [Fact()]
        public void TrackStreet()
        {
            var obj = new Contractor();
            obj.Street = "street1";
            Assert.Equal("street1", obj.Street);
        }

        [Fact()]
        public void TrackBuildingNumber()
        {
            var obj = new Contractor();
            obj.BuildingNumber = "building1";
            Assert.Equal("building1", obj.BuildingNumber);
        }

        [Fact()]
        public void TrackFlatNumber()
        {
            var obj = new Contractor();
            obj.FlatNumber = "flat1";
            Assert.Equal("flat1", obj.FlatNumber);
        }

        [Fact()]
        public void TrackPostalCode()
        {
            var obj = new Contractor();
            obj.PostalCode = "30-133";
            Assert.Equal("30-133", obj.PostalCode);
        }

        [Fact()]
        public void TrackCity()
        {
            var obj = new Contractor();
            obj.City = "City1";
            Assert.Equal("City1", obj.City);
        }
    }
}
