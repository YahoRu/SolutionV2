using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LibraryLesson9
{
    public class MyCollection<T> : IIndexatorable, IChangable where T : Transport
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
            if (index < NumberOfElements)
            {
                Console.WriteLine(Array[index].ToString());
            }
            else
            {
                Console.WriteLine("Элемента с таким индексом не найдено!");
            }
        }
    }
}

