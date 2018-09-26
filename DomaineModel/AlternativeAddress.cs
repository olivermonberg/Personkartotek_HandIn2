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
        public virtual long AlternativeAddressID { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
