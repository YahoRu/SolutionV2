using System;

namespace ClassLibraryLesson6
{
    public class Book
    {

        private string BookTitle { get; set; }
        private Library Library { get; set; }
        private int CountOfPages { get; set; }

        public Book(string bookTitle, int countOfPages)
        {
            BookTitle = bookTitle;
            CountOfPages = countOfPages;
        }

        public void AddToLibrary(Library LibraryName)
        {
            this.Library = LibraryName;

        }

        public string GetInfo()
        {
            string info = ($"Название: {this.BookTitle}, Библиотека: {this.Library.ToString()}, Количество стр.: {this.CountOfPages}");

            return info;
        }

        public string GetName()
        {
            string info = this.BookTitle;

            return info;
        }

        public int GetCountOfPages()
        {
            int count = this.CountOfPages;

            return count;
        }

    }
}
