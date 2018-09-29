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
            string _Gender, long _AddressID)
        {
            FirstName = _FirstName;
            LastName = _LastName;
            Nationality = _Nationality;
            Gender = _Gender;
            AddressID = _AddressID;

            //AddressID = GetAddressIDByStreetNameAndNumber(_Address.StreetName, _Address.StreetNumber); //Create if not found
            //PrimaryAddress = GetAddressObjectByAddressID(AddressID);
            //PrimaryAddress.Addresses.Add(this);

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
