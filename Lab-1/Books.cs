using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    public class Book
    {
        public uint Id;

        public string Author;

        public string Title;

        public uint PublicationYear;

        public uint CabinetNumber;

        public uint ShelfNumber;

        public string ToString()
        {
            return Id + Author + Title + ShelfNumber;
        }

    }
}
