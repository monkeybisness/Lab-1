using System.Globalization;

namespace Lab
{
    class Program
    {
        CultureInfo cultureInfo = new CultureInfo("ru-RU", false);

        public static void Main(string[] args)
        {
            List<Reader> readers = new List<Reader>
            {
                new Reader
                {
                    Id = 1,

                    FullName = "Андреев Андрей Андреевич",

                    ReaderTicket = 1,

                    DateCapture = new Dictionary<uint, DateTime> { { 2, new DateTime(2011, 11, 11) } },

                    DateReturn = new Dictionary<uint, DateTime>{ { 2, new DateTime(2022, 12, 12) } }
                },

                new Reader
                {
                    Id= 2,

                    FullName = "Иванов Иван Иванович",

                    ReaderTicket = 2,

                    DateCapture = new Dictionary<uint, DateTime>{ { 1, new DateTime(2023, 03, 27) } }
                },

                new Reader
                {
                    Id = 3,

                    FullName = "Богданов Богдан Богданович",

                    ReaderTicket = 3,

                    DateCapture = new Dictionary<uint, DateTime>{ { 3, new DateTime(2022, 11, 29) } },

                    DateReturn = new Dictionary<uint, DateTime>{ { 3, new DateTime(2023, 02, 24) } }
                },

            };

            List<Book> books = new List<Book>
            {
                new Book
                {
                    Id = 1,

                    Author = "Толстой Л. Н.",

                    Title = "Война и Мир",

                    PublicationYear = 1867,

                    CabinetNumber = 1,

                    ShelfNumber = 1
                },

                new Book
                {
                    Id = 2,

                    Author = "Лермонтов М. Ю.",

                    Title = "Герой нашего времени",

                    PublicationYear = 1840,

                    CabinetNumber = 1,

                    ShelfNumber = 1
                },

                new Book
                {
                    Id = 3,

                    Author = "Гоголь Н. В.",

                    Title = "Мёртвые души",

                    PublicationYear = 1842,

                    CabinetNumber = 1,

                    ShelfNumber = 2
                },

            };
            foreach (Book book in books)
            {
                Console.WriteLine(book.ToString());
            }
            foreach (Reader reader in readers)
            {
                Console.WriteLine(reader.ToString());
            }
        }
    }
}