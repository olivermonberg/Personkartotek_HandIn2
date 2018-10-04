using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaineModel
{
    public class Person
    {
        //public Person(string _FirstName, string _LastName, string _Nationality,
        //string _Gender, Address _Address)
        public Person(string _FirstName, string _LastName, string _Nationality,
            string _Gender, Address _Address)
        {
            FirstName = _FirstName;
            LastName = _LastName;
            Nationality = _Nationality;
            Gender = _Gender;
            AddressID = _Address.AddressID;
            //_Address.Persons.Add(this);

            //AddressID = GetAddressIDByStreetNameAndNumber(_Address.StreetName, _Address.StreetNumber); //Create if not found
            //PrimaryAddress = GetAddressObjectByAddressID(AddressID);
            //PrimaryAddress.Persons.Add(this);

            AlternativeAddresses = new List<AlternativeAddress>();
            Notes = new List<Note>();
            Emails = new List<Email>();
            PhoneNumbers = new List<PhoneNumber>();
        }

        public virtual long PersonID { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Nationality { get; set; }
        public virtual string Gender { get; set; }
        public virtual Address PrimaryAddress { get; set; }
        public virtual long AddressID { get; set; }
        public virtual ICollection<AlternativeAddress> AlternativeAddresses { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<Email> Emails { get; set; }
        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }
    }
}
