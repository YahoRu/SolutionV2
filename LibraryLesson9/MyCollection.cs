﻿using System;

namespace LibraryLesson9
{
    public class MyCollection<T> where T : Transport
    {
        private T[] Array;
        private int NumberOfElements { get; set; }

        public int AllElements { get => NumberOfElements; }

        public MyCollection()
        {
             this.Array = new T[10];
        }

        public void AddInCollection(T item)
        {
            if (Array.Length <= NumberOfElements)
            {
                T[] newArray = new T[Array.Length + 10];
                Array = newArray;
            }

            Array[NumberOfElements] = item;

            ++NumberOfElements;

        }

        public void Indexator(int index)
        {
            Console.WriteLine(Array[index].ToString());
        }


    }
}
