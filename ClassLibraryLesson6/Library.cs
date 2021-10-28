﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLesson6
{
    public class Library
    {

        private Book[] ArrayWithBooks = new Book[10];


        public Library(Book[] arrayWithBooks)
        {
            ArrayWithBooks = arrayWithBooks;
            foreach (Book item in arrayWithBooks)
            {
                item.AddToLibrary(this);
            }
        }

        public void BookInfo(int index)
        {
            Console.WriteLine(ArrayWithBooks[index].GetInfo());
        }

        public void FoundABook(string bookName)
        {
            for (int i = 0; i < ArrayWithBooks.Length; i++)
            {
                if (ArrayWithBooks[i].GetName().Equals(bookName))
                {
                    Console.WriteLine(ArrayWithBooks[i].GetInfo());
                    break;
                }
                else if (i == (ArrayWithBooks.Length - 1))
                {
                    Console.WriteLine("Такой книги нет!");
                }
            }
        }

        public void BiggestBook()
        {
            int biggestCount = ArrayWithBooks[0].GetCountOfPages();
            for (int i = 0; i < ArrayWithBooks.Length; i++)
            {

                if (ArrayWithBooks[i].GetCountOfPages() > biggestCount)
                {
                    biggestCount = ArrayWithBooks[i].GetCountOfPages();

                }
                else if (i == ArrayWithBooks.Length - 1)
                {
                    Console.WriteLine($"Самая большая книга это {ArrayWithBooks[i].GetName()}");
                    break;
                }

            }
        }
    }
}
