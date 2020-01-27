using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace ListTests
{
    [TestClass]
    public class Overload_Tests
    {
        //Tests the + operator to make sure it's adding each of the items in the second list onto the first one
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            MyList<int> myList = new MyList<int>();
            MyList<int> myList1 = new MyList<int>();
            MyList<int> expectedResult = new MyList<int>();
            MyList<int> actualResult = new MyList<int>();

            //Act
            expectedResult.Add(1);
            expectedResult.Add(2);
            expectedResult.Add(3);
            expectedResult.Add(4);
            expectedResult.Add(5);
            expectedResult.Add(6);

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            myList1.Add(4);
            myList1.Add(5);
            myList1.Add(6);

            actualResult = myList + myList1;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
