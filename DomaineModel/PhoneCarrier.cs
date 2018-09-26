using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaineModel
{
    public class PhoneCarrier
    {
        public virtual long PhoneCarrierID { get; set; }
        public virtual string CompanyName { get; set; }

        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }
    }
}
