using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaineModel
{
    public class PhoneNumber
    {
        public PhoneNumber(string _Num, PhoneCarrier _Carrier)
        {
            Num = _Num;
            Carrier = _Carrier;
            Carrier.PhoneNumbers.Add(this);
        }
        public virtual long PhoneNumberID { get; set; }
        public virtual long PersonID { get; set; }
        public virtual long PhoneCarrierID { get; set; }
        public virtual string Num { get; set; }
        public virtual PhoneCarrier Carrier { get; set; }
    }
}
