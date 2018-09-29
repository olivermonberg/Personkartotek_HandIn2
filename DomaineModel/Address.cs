using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaineModel
{
    public class Address
    {
        public Address(string _StreetName, string _StreetNumber, long City)
        {
            StreetName = _StreetName;
            StreetNumber = _StreetNumber;
            CityID = City;

            Persons = new List<Person>();
            
            //CityID = GetCityIDByName();
            //City = GetCityObjectByID(); //reference
            //City.Addresses.Add(this);
        }
        public virtual long AddressID { get; set; }
        public virtual long CityID { get; set; }
        public virtual string StreetName { get; set; }
        public virtual string StreetNumber { get; set; }
        public virtual City City { get; set; }
        public virtual ICollection<Person> Persons { get; set; }
    }
}
