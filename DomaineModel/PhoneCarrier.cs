using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaineModel
{
    public class PhoneCarrier
    {
        public PhoneCarrier(string _CompanyName)
        {
            CompanyName = _CompanyName;
            PhoneNumbers = new List<PhoneNumber>();
        }
        public virtual long PhoneCarrierID { get; set; }
        public virtual string CompanyName { get; set; }
        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }
    }
}
