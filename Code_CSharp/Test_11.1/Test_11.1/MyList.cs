using System;
using System.Collections.Generic;

namespace Test_11._1
{
    class MyList<T>
    {
        public int Count;
        public int Capacity = 4;
        public T[] values;
            
        public MyList(int Capacity)
        {
            this.Capacity = Capacity;
            values = new T[Capacity];
        }
        public void Add(T item)
        {
             if(Count == Capacity)
            {
                Capacity *= 2;
                T[] newValues = new T[Capacity];
                for (int i = 0; i < Count; i++) 
                {
                    newValues[i] = values[i];
                }
                values = newValues;
            }
            values[Count] = item;
            Count++;
        }
        public void Insert(int index, T item)
        {
            if (Count == Capacity)
            {
                Capacity *= 2;
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
            Count++;
        }
        public void RemoveAt(int index)
        {
            for(int i = index; i < Count; i++)
            {
                values[i] = values[i + 1];
            }
        }
        //public void Remove(T item)
        //{
        //    int index = 0;
        //    for(int i = 0;i < Count;i++)
        //    {
        //        if (item == values[i])
        //        {
        //            index = i;
        //            break;
        //        }
        //    }
        //    for (int i = index; i < Count; i++)
        //    {
        //        values[i] = values[i + 1];
        //    }
        //}
        //public int IndexOf(T item)
        //{
        //    for (int i = 0; i < Count; i++)
        //    {
        //        if (item == values[i])
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}
        //public int LastIndexOf(T item)
        //{
        //    for (int i = Count - 1; i >= 0; i--)
        //    {
        //        if (item == values[i])
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}
    }
}
