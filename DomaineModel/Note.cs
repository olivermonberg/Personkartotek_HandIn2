using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaineModel
{
    public class Note
    {
        public virtual long NoteID { get; set; }
        public virtual string NoteText { get; set; }
    }
}
