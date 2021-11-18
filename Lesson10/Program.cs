using System;
using System.Collections.Generic;
using LibraryLesson10;

namespace Lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new MyItem();
            var list2 = new MyItem();

            var newList = new MyList() { list2 };

            Console.WriteLine(newList.Count);

            newList.Add(list1);

            Console.WriteLine(newList.Count);
        }
    }
}
