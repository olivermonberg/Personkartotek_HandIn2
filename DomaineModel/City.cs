using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaineModel
{
    public class City
    {
        public City(string _cityName, string _postalCode, string _country)
        {
            CityName = _cityName;
            PostalCode = _postalCode;
            Country = _country;
            Addresses = new List<Address>();
        }
        public virtual long CityID { get; set; }
        public virtual string PostalCode { get; set; }
        public virtual string Country { get; set; }
        public virtual string CityName { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
