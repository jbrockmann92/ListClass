using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace ListTests
{
    [TestClass]
    public class StringConvertTests
    {
        //Tests to make sure the string returned is in the right order
        [TestMethod]
        public void CheckStringOrder()
        {
            //Arrange
            MyList<string> myList = new MyList<string>();
            string expectedResult = "MaryPaulPoppy";
            string actualResult;

            //Act
            myList.Add("Mary");
            myList.Add("Paul");
            myList.Add("Poppy");
            actualResult = myList.ToString();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        //Tests to make sure the method returns a string, not an array
        [TestMethod]
        public void CheckStringIsReturned()
        {
            //Arrange
            MyList<string> myList = new MyList<string>();
            string expectedResult = "MaryPaulPoppy";
            string actualResult;

            //Act
            myList.Add("Mary");
            myList.Add("Paul");
            myList.Add("Poppy");
            actualResult = myList.ToString();

            //Assert
            Assert.IsTrue(expectedResult == actualResult);
        }

        //Tests to make sure the method returns a string every item in the list
        [TestMethod]
        public void CheckStringContainsAllItems()
        {
            //Arrange
            MyList<string> myList = new MyList<string>();
            string expectedResult = "MaryPaulPoppyDaveJamesBonnie";
            string actualResult;

            //Act
            myList.Add("Mary");
            myList.Add("Paul");
            myList.Add("Poppy");
            myList.Add("Dave");
            myList.Add("James");
            myList.Add("Bonnie");
            actualResult = myList.ToString();

            //Assert
            Assert.IsTrue(expectedResult == actualResult);
        }

        //Checks to make sure ints are returned as strings
        [TestMethod]
        public void CheckIntReturnsAsString()
        {
            //Arrange
            MyList<int> myList = new MyList<int>();
            string expectedResult = "175";
            string actualResult;

            //Act
            myList.Add(1);
            myList.Add(7);
            myList.Add(5);
            actualResult = myList.ToString();

            //Assert
            Assert.IsTrue(expectedResult == actualResult);
        }
    }
}
