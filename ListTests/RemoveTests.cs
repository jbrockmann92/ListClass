using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace ListTests
{
    [TestClass]
    public class RemoveTests
    {
        //Tests to make sure that the remove function removes what it's supposed to remove
        [TestMethod]
        public void CheckIfRemoveFunctionRemoves()
        {
            //Arrange
            MyList<string> myList = new MyList<string>();
            string expectedNames = "Mary Dave";
            string actualNames;

            //Act
            myList.Add("Mary");
            myList.Add("Murphy");
            myList.Add("Dave");
            myList.Remove("Murphy");
            actualNames = myList[0] + myList[1];

            //Assert
            Assert.AreNotEqual(expectedNames, actualNames);
        }

        //Tests [0] after removing a number from the list
        [TestMethod]
        public void CheckZeroIndexAfterRemove()
        {
            //Arrange
            MyList<int> myList = new MyList<int>();
            int expectedResult = 5;
            int actualResult;

            //Act
            myList.Add(5);
            myList.Add(20);
            myList.Remove(20);
            actualResult = myList[0];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        //Tests [0] after removing the first item in the list
        [TestMethod]
        public void CheckOneIndexAfterRemove()
        {
            //Arrange
            MyList<int> myList = new MyList<int>();
            int expectedResult = 20;
            int actualResult;

            //Act
            myList.Add(5);
            myList.Add(20);
            myList.Remove(5);
            actualResult = myList[0];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        //Tests what happens if they try to remove something that's not in the list. Should not remove anything
        [TestMethod]
        public void CheckRemoveNotInList()
        {
            //Arrange
            MyList<int> myList = new MyList<int>();
            int expectedResult = 2;
            int actualResult;

            //Act
            myList.Add(5);
            myList.Add(20);
            myList.Remove(10);
            actualResult = myList.Count;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestRemoveDuplicateOnlyOnce()
        {
            //Arrange
            MyList<int> myList = new MyList<int>();
            int expectedResult = 2;
            int actualResult;

            //Act
            myList.Add(5);
            myList.Add(20);
            myList.Add(20);
            myList.Remove(20);
            actualResult = myList.Count;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
