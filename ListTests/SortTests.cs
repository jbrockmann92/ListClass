using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace ListTests
{
    [TestClass]
    public class SortTests
    {
        //Tests to make sure sort puts ints in descending order
        [TestMethod]
        public void TestIfSortPutsIntsInDescendingOrder()
        {
            //Arrange
            MyList<int> myList = new MyList<int>();
            MyList<int> resultingList = new MyList<int>();
            string actualResult;
            string expectedResult = "12359";

            //Act
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(5);
            myList.Add(9);

            //resultingList = myList.Sort();
            actualResult = resultingList.ToString();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
