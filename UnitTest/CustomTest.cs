using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTest
{
    [TestClass]
    public class CustomTest
    {
        [TestMethod]
        public void Add_AddItemToList_CountIsOne()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;

            // act
            testList.Add(12);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddItemToList_CountIsThree()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 3;
            int actual;

            // act
            testList.Add(12);
            testList.Add(24);
            testList.Add(36);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddToEmptyList_ItemGoesToIndexZero()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 12;
            int actual;

            // act
            testList.Add(12);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemToList_ItemGoesToIndexOne()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 24;
            int actual;

            // act
            testList.Add(12);
            testList.Add(24);
            actual = testList[1];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemToList_ItemGoesToIndexTwo()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 36;
            int actual;

            // act
            testList.Add(12);
            testList.Add(24);
            testList.Add(36);
            actual = testList[2];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddItemToList_LengthOfArrayGrows()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 4;
            int actual;

            // act
            testList.Add(12);
            testList.Add(34);
            testList.Add(36);
            actual = testList.Capacity;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveItemFromList_CountIsOne()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;

            // act
            testList.Add(12);
            testList.Add(24);
            testList.Remove(24);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveItemFromList_IndexZeroIsTwelve()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 12;
            int actual;

            // act
            testList.Add(12);
            testList.Add(24);
            testList.Remove(24);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveItemFromList_ItemGoestoIndexZero()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 24;
            int actual;

            // act
            testList.Add(12);
            testList.Add(24);
            testList.Remove(12);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveMiddleItemFromList_ListCountDecreases()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 2;
            int actual;

            // act
            testList.Add(12);
            testList.Add(24);
            testList.Add(36);
            testList.Remove(24);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveMiddleItemFromList_IndexOneIsThirtySix()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 36;
            int actual;

            // act
            testList.Add(12);
            testList.Add(24);
            testList.Add(36);
            testList.Remove(24);
            actual = testList[1];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveFirstTwelve_ItemCountIsTwo()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 2;
            int actual;

            // act
            testList.Add(12);
            testList.Add(12);
            testList.Add(24);
            testList.Remove(12);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_ConcatenateInt_12345()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            string expected = "12345";
            string actual;

            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            actual = testList.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_ConcatenateInt_godoggo()
        {
            // arrange
            CustomList<string> testList = new CustomList<string>();
            string expected = "godoggo";
            string actual;

            // act
            testList.Add("go");
            testList.Add("dog");
            testList.Add("go");
            actual = testList.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
