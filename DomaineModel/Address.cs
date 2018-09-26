using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaineModel
{
    public class Address
    {
        public virtual long AddressID { get; set; }
        public virtual string StreetName { get; set; }
        public virtual string StreetNumber { get; set; }
        
    }
}
