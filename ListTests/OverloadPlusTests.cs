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
        public void TestAddingListsTogether()
        {
            //Arrange
            MyList<int> myList = new MyList<int>();
            MyList<int> myList1 = new MyList<int>();
            string expectedResult = "123456";
            MyList<int> actualResultList = new MyList<int>();

            //Act

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            myList1.Add(4);
            myList1.Add(5);
            myList1.Add(6);

            actualResultList = myList + myList1;
            string actualResult = actualResultList.ToString();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        //Tests the + operator to make sure it's adding each of the items in the second list onto the first one
        [TestMethod]
        public void TestListWithDuplicates()
        {
            //Arrange
            MyList<int> myList = new MyList<int>();
            MyList<int> myList1 = new MyList<int>();
            string expectedResult = "123123";
            MyList<int> actualResultList = new MyList<int>();

            //Act

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            myList1.Add(1);
            myList1.Add(2);
            myList1.Add(3);

            actualResultList = myList + myList1;
            string actualResult = actualResultList.ToString();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
