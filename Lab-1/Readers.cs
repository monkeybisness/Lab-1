using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Reader
    {
        public uint Id;

        public string FullName;

        public uint ReaderTicket;

        public Dictionary<uint, DateTime> DateCapture;

        public Dictionary<uint, DateTime> DateReturn;
        public string ToString()
        {
            return Id + FullName + ReaderTicket + DateCapture.ToList()[0] + DateReturn;
        }
    }
}
