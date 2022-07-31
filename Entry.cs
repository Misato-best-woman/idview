using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdView
{
    public class Entry
    {        
        public string path;
        public string sideNote;
        public string category;
        public string isDone;

        public Entry(string path, string sideNote, string category, string isDone)
        {
            this.path = path;
            this.sideNote = sideNote;  
            this.category = category;
            this.isDone = isDone;
        }
    }
}
