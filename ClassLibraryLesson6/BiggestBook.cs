using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLesson6
{
    public static class BiggestBook
    {

        public static void BiggestBookFounder(this Library lib)
        {

            int biggestCount = lib.ArrayWithBooks[0].GetCountOfPages();
            string longestBook = null;

            for (int i = 0; i < lib.ArrayWithBooks.Length; i++)
            {

                if (lib.ArrayWithBooks[i].GetCountOfPages() > biggestCount)
                {
                    biggestCount = lib.ArrayWithBooks[i].GetCountOfPages();

                    longestBook = lib.ArrayWithBooks[i].GetName();

                }
                else if (i == lib.ArrayWithBooks.Length - 1)
                {
                    Console.WriteLine($"Самая большая книга это: ");
                    lib.FoundABook(longestBook);
                    break;
                }

            }
        }
    }
}
