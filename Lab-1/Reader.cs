using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Reader
    {
        public uint Id { get; set; }

        public string FullName { get; set; }

        public uint ReaderTicket { get; set; }

        public Dictionary<uint, DateTime> DateCapture { get; set; }

        public Dictionary<uint, DateTime> DateReturn { get; set; }
        public string ToString()
        {
            return Id + FullName + ReaderTicket + DateCapture.ToList()[0] + DateReturn;
        }
    }
}
