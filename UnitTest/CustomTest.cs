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
        public void ToString_ConcatenateString_godoggo()
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
        [TestMethod]
        public void ToString_ConcatenateString_godoggocatdog()
        {
            // arrange
            CustomList<string> testList = new CustomList<string>();
            string expected = "godoggocatdog";
            string actual;

            // act
            testList.Add("go");
            testList.Add("dog");
            testList.Add("go");
            testList.Add("cat");
            testList.Add("dog");
            actual = testList.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PlusOperator_ConcatenateCustomList_CountIsSix()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> concatList = new CustomList<int>();
            int expected = 6;
            int actual;

            // act
            testList1.Add(3);
            testList1.Add(2);
            testList1.Add(1);
            testList2.Add(4);
            testList2.Add(6);
            testList2.Add(5);
            concatList = testList1 + testList2;
            actual = concatList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PlusOperator_ConcatenateCustomList_IndexZeroIsOne()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> concatList = new CustomList<int>();
            int expected = 1;
            int actual;

            // act
            testList1.Add(1);
            testList1.Add(2);
            testList1.Add(3);
            testList2.Add(4);
            testList2.Add(5);
            testList2.Add(6);
            concatList = testList1 + testList2;
            actual = concatList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PlusOperator_ConcatenateCustomList_IndexOneIsTwo()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> concatList = new CustomList<int>();
            int expected = 2;
            int actual;

            // act
            testList1.Add(1);
            testList1.Add(2);
            testList1.Add(3);
            testList2.Add(4);
            testList2.Add(5);
            testList2.Add(6);
            concatList = testList1 + testList2;
            actual = concatList[1];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PlusOperator_ConcatenateCustomList_IndexTwoIsThree()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> concatList = new CustomList<int>();
            int expected = 3;
            int actual;

            // act
            testList1.Add(1);
            testList1.Add(2);
            testList1.Add(3);
            testList2.Add(4);
            testList2.Add(5);
            testList2.Add(6);
            concatList = testList1 + testList2;
            actual = concatList[2];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PlusOperator_ConcatenateCustomList_IndexThreeIsFour()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> concatList = new CustomList<int>();
            int expected = 4;
            int actual;

            // act
            testList1.Add(1);
            testList1.Add(2);
            testList1.Add(3);
            testList2.Add(4);
            testList2.Add(5);
            testList2.Add(6);
            concatList = testList1 + testList2;
            actual = concatList[3];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PlusOperator_ConcatenateCustomList_IndexFourIsFive()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> concatList = new CustomList<int>();
            int expected = 5;
            int actual;

            // act
            testList1.Add(1);
            testList1.Add(2);
            testList1.Add(3);
            testList2.Add(4);
            testList2.Add(5);
            testList2.Add(6);
            concatList = testList1 + testList2;
            actual = concatList[4];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PlusOperator_ConcatenateCustomList_IndexFiveIsSix()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> concatList = new CustomList<int>();
            int expected = 6;
            int actual;

            // act
            testList1.Add(1);
            testList1.Add(2);
            testList1.Add(3);
            testList2.Add(4);
            testList2.Add(5);
            testList2.Add(6);
            concatList = testList1 + testList2;
            actual = concatList[5];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MinusOperator_RemoveItemsToCreateNewList_CountIsTwo()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();
            int expected = 2;
            int actual;

            // act
            testList1.Add(1);
            testList1.Add(3);
            testList1.Add(2);
            testList2.Add(2);
            testList2.Add(1);
            testList2.Add(6);
            newList = testList1 - testList2;
            actual = newList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MinusOperator_RemoveItemsToCreateNewList_IndexZeroIsThree()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();
            int expected = 3;
            int actual;

            // act
            testList1.Add(1);
            testList1.Add(3);
            testList1.Add(2);
            testList2.Add(2);
            testList2.Add(1);
            testList2.Add(6);
            newList = testList1 - testList2;
            actual = newList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MinusOperator_RemoveItemsToCreateNewList_IndexOneIsSix()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();
            int expected = 6;
            int actual;

            // act
            testList1.Add(1);
            testList1.Add(3);
            testList1.Add(2);
            testList2.Add(2);
            testList2.Add(1);
            testList2.Add(6);
            newList = testList1 - testList2;
            actual = newList[1];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MinusOperator_RemoveItemsToCreateNewList_IndexZeroIsSix()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();
            int expected = 6;
            int actual;

            // act
            testList1.Add(6);
            testList1.Add(4);
            testList1.Add(8);
            testList2.Add(8);
            testList2.Add(3);
            testList2.Add(4);
            newList = testList1 - testList2;
            actual = newList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MinusOperator_RemoveItemsToCreateNewList_IndexOneIsThree()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();
            int expected = 3;
            int actual;

            // act
            testList1.Add(6);
            testList1.Add(4);
            testList1.Add(8);
            testList2.Add(8);
            testList2.Add(3);
            testList2.Add(4);
            newList = testList1 - testList2;
            actual = newList[1];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipFunction_ZipsTwoCustomListsTogether_CountIsSix()
        {
            // arrange
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> even = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();
            int expected = 6;
            int actual;

            // act
            odd.Add(1);
            odd.Add(3);
            odd.Add(5);
            even.Add(2);
            even.Add(4);
            even.Add(6);
            newList = odd.Zip(even);
            actual = newList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipFunction_ZipsTwoCustomListsTogether_IndexZeroIsOne()
        {
            // arrange
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> even = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();
            int expected = 1;
            int actual;

            // act
            odd.Add(1);
            odd.Add(3);
            odd.Add(5);
            even.Add(2);
            even.Add(4);
            even.Add(6);
            newList = odd.Zip(even);
            actual = newList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipFunction_ZipsTwoCustomListsTogether_IndexOneIsTwo()
        {
            // arrange
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> even = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();
            int expected = 2;
            int actual;

            // act
            odd.Add(1);
            odd.Add(3);
            odd.Add(5);
            even.Add(2);
            even.Add(4);
            even.Add(6);
            newList = odd.Zip(even);
            actual = newList[1];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipFunction_ZipsTwoCustomListsTogether_IndexTwoIsThree()
        {
            // arrange
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> even = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();
            int expected = 3;
            int actual;

            // act
            odd.Add(1);
            odd.Add(3);
            odd.Add(5);
            even.Add(2);
            even.Add(4);
            even.Add(6);
            newList = odd.Zip(even);
            actual = newList[2];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipFunction_ZipsTwoCustomListsTogether_IndexThreeIsFour()
        {
            // arrange
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> even = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();
            int expected = 4;
            int actual;

            // act
            odd.Add(1);
            odd.Add(3);
            odd.Add(5);
            even.Add(2);
            even.Add(4);
            even.Add(6);
            newList = odd.Zip(even);
            actual = newList[3];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipFunction_ZipsTwoCustomListsTogether_IndexFourIsFive()
        {
            // arrange
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> even = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();
            int expected = 5;
            int actual;

            // act
            odd.Add(1);
            odd.Add(3);
            odd.Add(5);
            even.Add(2);
            even.Add(4);
            even.Add(6);
            newList = odd.Zip(even);
            actual = newList[4];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZipFunction_ZipsTwoCustomListsTogether_IndexFiveIsSix()
        {
            // arrange
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> even = new CustomList<int>();
            CustomList<int> newList = new CustomList<int>();
            int expected = 6;
            int actual;

            // act
            odd.Add(1);
            odd.Add(3);
            odd.Add(5);
            even.Add(2);
            even.Add(4);
            even.Add(6);
            newList = odd.Zip(even);
            actual = newList[5];

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
