using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaineModel
{
    public class AlternativeAddress
    {
        public AlternativeAddress(Person _person, Address _address, string _type)
        {
            Type = _type;
            Addresses.Add(_address);
            Persons.Add(_person);

            Addresses = new List<Address>();
            Persons = new List<Person>();
        }
        public virtual long AlternativeAddressID { get; set; }
        public virtual string Type { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Person> Persons { get; set; }
    }
}
