using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaineModel
{
    public class City
    {
        public virtual long CityID { get; set; }
        public virtual string PostalCode { get; set; }
        public virtual string Country { get; set; }
        public virtual string CityName { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
