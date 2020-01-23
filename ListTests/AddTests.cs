using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace ListTests
{
    [TestClass]
    public class AddTests
    {
        //Tests that the .Add function is adding the item to the list
        [TestMethod]
        public void CheckZeroIndexAfterAdd()
        {
            //Arrange
            MyList myList = new MyList();
            int expectedResult = 5;
            int actualResult;

            //Act
            myList.Add(5);
            actualResult = myList[0];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        //Tests .Count of the list after adding an item
        [TestMethod]
        public void CheckCountAfterAdd()
        {
            //Arrange
            MyList myList = new MyList();
            int expectedResult = 1;
            int actualResult;

            //Act
            myList.Add(5);
            actualResult = myList.Count;


            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        //Tests [1] after adding a second item to the list
        [TestMethod]
        public void CheckIndexOneAfterAddingSecondItem()
        {
            //Arrange
            MyList myList = new MyList();
            int expectedResult = 5;
            int actualResult;

            //Act
            myList.Add(2);
            myList.Add(5);
            actualResult = myList[1];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        //Tests [0] after adding a second item to the list to make sure it's still there
        [TestMethod]
        public void CheckIndexZeroAfterAddingSecondItem()
        {
            //Arrange
            MyList myList = new MyList();
            int expectedResult = 5;
            int actualResult;

            //Act
            myList.Add(5);
            myList.Add(2);
            actualResult = myList[0];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        //Tests to see if the Array inside the List expands by 4 when you add an item beyond its current length. Default will be 4
        [TestMethod]
        public void CheckArrayExpansion()
        {
            //Arrange
            MyList myList = new MyList();
            int expectedResult = 8;
            int actualResult;

            //Act
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            actualResult = myList.Capacity;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        //Tests to make sure you can add two of the same things to the list
        [TestMethod]
        public void CheckDuplicateData()
        {
            //Arrange
            MyList myList = new MyList();
            int expectedResult = 2;
            int actualResult;

            //Act
            myList.Add(5);
            myList.Add(5);
            actualResult = myList.Count;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
} 