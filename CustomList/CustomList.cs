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

        //constructor
        public CustomList()
        {
            items = new T[4];
        }

        public int Count
        {
            get
            {
                count = items.Length;
                return count;
            }
        }
    }
}
