using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaineModel
{
    public class Address
    {
        //public Address(string _StreetName, string _StreetNumber, City _City)
        public Address(string _StreetName, string _StreetNumber, City _City)
        {
            StreetName = _StreetName;
            StreetNumber = _StreetNumber;
            CityID = _City.CityID;
            //_City.Addresses.Add(this);
            Persons = new List<Person>();

            //PKDBUtil _pkdbUtil = new PKDBUtil();

            //PKDBUtil.GetCityIDByCityNameAndPostalCodeAndCountry(_City);
            //GetCityObjectByID(_City); //reference
            
        }
        public virtual long AddressID { get; set; }
        public virtual long CityID { get; set; }
        public virtual string StreetName { get; set; }
        public virtual string StreetNumber { get; set; }
        public virtual City City { get; set; }
        public virtual ICollection<Person> Persons { get; set; }
    }
}
