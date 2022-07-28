using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdView
{
    public struct Entry
    {
        public string id;
        public string blob;
        public string sideNote;
        public string category;
        public string isDone;

        public Entry(string id, string blob, string sideNote, string category, string isDone)
        {
            this.id = id;
            this.blob = blob;
            this.sideNote = sideNote;  
            this.category = category;
            this.isDone = isDone;
        }
    }
}
