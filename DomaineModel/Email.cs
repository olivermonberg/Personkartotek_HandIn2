using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaineModel
{
    public class Email
    {
        public Email(string _emailAddress)
        {
            EmailAddress = _emailAddress;
        }
        public virtual long EmailID { get; set; }
        public virtual string EmailAddress { get; set; }
    }
}
