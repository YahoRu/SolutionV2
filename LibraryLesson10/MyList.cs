using System;
using System.Collections;
using System.Collections.Generic;

namespace LibraryLesson10
{
    public class MyList : IList<MyItem>
    {
        readonly IList<MyItem> newList = new List<MyItem>();

        public MyItem this[int index] { get => newList[index]; set => newList[index] = value; }

        public int Count => newList.Count;

        public bool IsReadOnly => newList.IsReadOnly;

        public void Add(MyItem item)
        {
            newList.Add(item);
        }

        public void Clear()
        {
            newList.Clear();
        }

        public bool Contains(MyItem item)
        {
            return newList.Contains(item);
        }

        public void CopyTo(MyItem[] array, int arrayIndex)
        {
            newList.CopyTo(array, arrayIndex);
        }

        public IEnumerator<MyItem> GetEnumerator()
        {
            return newList.GetEnumerator();
        }

        public int IndexOf(MyItem item)
        {
            return newList.IndexOf(item);
        }

        public void Insert(int index, MyItem item)
        {
            newList.Insert(index, item);
        }

        public bool Remove(MyItem item)
        {
            return newList.Remove(item);
        }

        public void RemoveAt(int index)
        {
            newList.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)newList).GetEnumerator();
        }
    }
}
