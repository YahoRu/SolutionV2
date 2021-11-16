using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LibraryLesson9
{
    public class AnyCollection<T> : IIndexatorable, IChangable where T : Transport
    {

        private T[] Array;

        private int NumberOfElements { get; set; }

        public int AllElements { get => NumberOfElements; }

        public AnyCollection()
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

