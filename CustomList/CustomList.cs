using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        private T[] items;
        private int count;
        private int capacity;

        //constructor
        public CustomList()
        {
            items = new T[1];
        }
        public void IncrementCount()
        {
            count++;
        }
        public void DecrementCount()
        {
            count--;
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public int Capacity
        {
            get
            {
                capacity = items.Length;
                return capacity;
            }
        }
        public T this[int index] //indexer
        {
            get
            {
                T temp;
                if(index >= 0 && index <= count - 1)
                {
                    temp = items[index];
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException("Index out of range");
                }
                return temp;
            }
            set
            {
                if(index >= 0 && index <= count - 1)
                {
                    items[index] = value;
                }
            }
        }
        public T[] Add(T item)
        {
            if(Count == Capacity)
            {
                GrowArray();
                items[count] = item;
                IncrementCount();
                return items;
            }
            else
            {
                items[count] = item;
                IncrementCount();
                return items;
            }
        }
        public T[] Remove(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i].Equals(item))
                {
                    DecrementCount();
                    for(int x = i; x < Count; x++)
                    {
                        items[x] = items[x + 1];
                    }
                    return items;
                }
                else
                {
                    continue;
                }
            }
            return items;
        }

        public T[] GrowArray()
        {
            int newSize = Capacity * 2;
            T[] tempArray = new T[newSize];
            CopyArray(tempArray);
            return items;
        }
        public T[] CopyArray(T[] tempArray)
        {
            for (int i = 0; i < items.Length; i++)
            {
                tempArray[i] = items[i];
            }
            items = tempArray;
            return items;
        }
        public override string ToString()
        {
            string temp = "";
            for(int i = 0; i < Count; i++)
            {
                temp += items[i].ToString();
            }
            return temp;
        }
        public static CustomList<T> operator + (CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> concatList = new CustomList<T>();
            for(int i = 0; i < list1.Count; i++)
            {
                concatList.Add(list1[i]);
            }
            for (int i = 0; i < list2.Count; i++)
            {
                concatList.Add(list2[i]);
            }
            return concatList;
        }

    }
}
