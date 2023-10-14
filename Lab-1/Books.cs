using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    public class Book
    {
        public uint Id { get; set; }

        public string Author { get; set; }

        public string Title { get; set; }

        public uint PublicationYear { get; set; }

        public uint CabinetNumber { get; set; }

        public uint ShelfNumber { get; set; }

        public string ToString()
        {
            return Id + Author + Title + ShelfNumber;
        }

    }
}
