using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();

            // act
            testList1.Add(6);
            testList1.Add(4);
            testList1.Add(8);
            testList2.Add(8);
            testList2.Add(3);
            testList2.Add(4);
            newList = testList1 - testList2;

        }
    }
}
