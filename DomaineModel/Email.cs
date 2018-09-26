using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaineModel
{
    public class Email
    {
        public virtual long EmailID { get; set; }
        public virtual string EmailAddress { get; set; }
    }
}
