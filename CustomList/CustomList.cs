﻿using System;
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
        public void IncrementCount()
        {
            count++;
        }
        public void DecrementCount()
        {
            count--;
        }
        public T[] Add(T item)
        {
            GrowArray();
            IncrementCount();
            return items;
        }
        public T[] GrowArray()
        {
            int doubleSize = Capacity * 2;
            T[] tempArray = new T[doubleSize];
            CopyArray(tempArray);
            return items;

        }
        public T[] CopyArray(T[] tempArray)
        {
            for (int i = 0; i < items.Length; i++)
            {
                tempArray[i] = items[i];
                IncrementCount();
            }
            items = tempArray;
            return items;
        }
    }
}
