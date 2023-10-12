using System.Globalization;
using System.Reflection.PortableExecutable;

namespace Lab
{
    class Program
    {
        CultureInfo cultureInfo = new CultureInfo("ru-RU", false);


        public static void Main(string[] args)
        { 
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

                    Author = "Толстой Л. Н.",

                    Title = "Анна Каренина",

                    PublicationYear = 1878,

                    CabinetNumber = 1,

                    ShelfNumber = 1
                },

                new Book
                {
                    Id = 3,

                    Author = "Толстой Л. Н.",

                    Title = "Казаки",

                    PublicationYear = 1863,

                    CabinetNumber = 1,

                    ShelfNumber = 2
                },

            };
        }
    }
}