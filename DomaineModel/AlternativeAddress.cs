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
            AddressID = _address.AddressID;
            PersonID = _person.PersonID;

            //PersonID = GetPersonIDByFirstAndLastNameAndCountry(_person.FirstName, _person.LastName, _person.Country);
            //Person = GetPersonObjectByPersonID(PersonID);
            //Person.AlternativeAddress.Add(this);
            //Persons.Add(Person);

            //AddressID = GetAddressIDByStreetNameAndNumber(_address.StreetName, _address.StreetNumber); //evt. City
            //Address = GetAddressObjectByAddressID(AddressID);
            //Address.Persons.Add(Person);

            //Addresses = new List<Address>();
            //Persons = new List<Person>();
        }
        public virtual long AlternativeAddressID { get; set; }
        public virtual long PersonID { get; set; }
        public virtual long AddressID { get; set; }
        public virtual string Type { get; set; }
        //public virtual ICollection<Address> Addresses { get; set; }
        //public virtual ICollection<Person> Persons { get; set; }
        //public virtual Address Address { get; set; }
        //public virtual Person Person { get; set; }
    }
}
