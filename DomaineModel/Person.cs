using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaineModel
{
    public class Person
    {
        /*public Person(string name, Address address)
        {
            Name = name;
            PrimaryAddress = address;
        }*/
        public virtual long PersonID { get; set; }
        public virtual string Name { get; set; }
        public virtual Address PrimaryAddress { get; set; }
        public virtual ICollection<AlternativeAddress> AlternativeAddresses { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<Email> Emails { get; set; }
        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }
    }
}
