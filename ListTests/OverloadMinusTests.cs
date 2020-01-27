using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace ListTests
{
    [TestClass]
    public class OverloadMinusTests
    {
        //Tests to make sure that the minus operator only removes one instance of each item
        [TestMethod]
        public void TestMinusOneListFromAnother()
        {
            //Arrange
            MyList<int> myList = new MyList<int>();
            MyList<int> myList1 = new MyList<int>();
            string expectedResult = "12";
            MyList<int> actualResultList = new MyList<int>();

            //Act

            myList.Add(1);
            myList.Add(2);
            myList.Add(2);

            myList1.Add(2);
            myList1.Add(5);
            myList1.Add(6);

            actualResultList = myList - myList1;
            string actualResult = actualResultList.ToString();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        //Tests to make sure that the minus operator removes the correct item(s) from the list
        [TestMethod]
        public void Test()
        {
            //Arrange
            MyList<int> myList = new MyList<int>();
            MyList<int> myList1 = new MyList<int>();
            string expectedResult = "17";
            MyList<int> actualResultList = new MyList<int>();

            //Act

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(7);

            myList1.Add(2);
            myList1.Add(3);
            myList1.Add(6);

            actualResultList = myList - myList1;
            string actualResult = actualResultList.ToString();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
