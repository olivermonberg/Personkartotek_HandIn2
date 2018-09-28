using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaineModel
{
    public class Note
    {
        public Note(string _noteText)
        {
            NoteText = _noteText;
        }
        public virtual long NoteID { get; set; }
        public virtual long PersonID { get; set; }
        public virtual string NoteText { get; set; }
    }
}
