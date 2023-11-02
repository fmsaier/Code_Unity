using System;
using System.Collections.Generic;

namespace Test_11._1
{
    class MyList<T>
    {
        private int count;
        private int capacity = 4;
        private T[] values;

        public int Count {  get { return count; } }
        public int Capacity { get { return capacity; } }

        public MyList()
        {
            values = new T[Capacity];
        }
        public MyList(int Capacity)
        {
            this.capacity = Capacity;
            values = new T[Capacity];
        }
        public void Add(T item)
        {
             if(Count == Capacity)
            {
                capacity *= 2;
                T[] newValues = new T[Capacity];
                for (int i = 0; i < Count; i++) 
                {
                    newValues[i] = values[i];
                }
                values = newValues;
            }
            values[Count] = item;
            count++;
        }
        public void Insert(int index, T item)
        {
            if (index < 0 || index >= Count)
                throw new IndexOutOfRangeException("下标越界");
            if (Count == Capacity)
            {
                capacity *= 2;
                T[] newValues = new T[Capacity];
                for (int i = 0; i < Count; i++)
                {
                    newValues[i] = values[i];
                }
                values = newValues;
            }
            for(int i = Count; i > index; i--)
            {
                values[i] = values[i - 1];
            }
            values[index] = item;
            count++;
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
                throw new IndexOutOfRangeException("下标越界");
            for (int i = index; i < Count; i++)
            {
                values[i] = values[i + 1];
            }
            count--;
        }
        public T this[int index]
        {
            get 
            { 
                if(index < 0 || index >= Count)
                    throw new IndexOutOfRangeException("下标越界");

                return values[index]; 
            }
            set
            {
                values[index] = value;
            }
        }

        public void Remove(T item)
        {
            int index = 0;
            for (int i = 0; i < Count; i++)
            {
                if (item.Equals(values[i]))
                {
                    index = i;
                    break;
                }
            }
            for (int i = index; i < Count; i++)
            {
                values[i] = values[i + 1];
            }
            count--;
        }
        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (item.Equals(values[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        public int LastIndexOf(T item)
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                if (item.Equals(values[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        public void Sort()
        {
            Array.Sort(values, 0, Count);
            //Array.Sort()
            //Array.Sort()
        }
    }
}
