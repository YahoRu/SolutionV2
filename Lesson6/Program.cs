using System;
using ClassLibraryLesson6;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Book Eragon = new Book("Eragon", 265);
            Book LordOfTheRing = new Book("LordOfTheRing", 450);
            Book History = new Book("History", 100);

            Book[] array = new Book[3] { Eragon, LordOfTheRing, History };

            Library libraryN1 = new Library(array);

            libraryN1.BookInfo(0);

            Console.WriteLine("Введите название книги(С учетом регистра):");

            string bookfound = Console.ReadLine();

            libraryN1.FoundABook(bookfound);

            libraryN1.BiggestBookFounder();
        }
    }
}

