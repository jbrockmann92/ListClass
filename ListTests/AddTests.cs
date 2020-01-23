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
            int testForArray = 5;

            //Act
            myList.Add(testForArray);

            //Assert
            Assert.AreEqual(testForArray, myList[0]);
        }

        //Tests .Count of the list after adding an item
        [TestMethod]
        public void CheckCountAfterAdd()
        {
            //Arrange
            MyList myList = new MyList();
            int testArrayCount = 1;

            //Act
            myList.Add(5);

            //Assert
            Assert.AreEqual(test, myList.Count);
        }

        //Tests [1] after adding a second item to the list
        [TestMethod]
        public void CheckIndexOneAfterAddingSecondItem()
        {
            //Arrange
            MyList myList = new MyList();
            int testIndexOne = 5;

            //Act
            myList.Add(2);
            myList.Add(testIndexOne);

            //Assert
            Assert.AreEqual(testIndexOne, myList[1]);
        }

        //Tests [0] after adding a second item to the list to make sure it's still there
        [TestMethod]
        public void CheckIndexZeroAfterAddingSecondItem()
        {
            //Arrange
            MyList myList = new MyList();
            int testIndexZero = 5;

            //Act
            myList.Add(testIndexZero);
            myList.Add(2);

            //Assert
            Assert.AreEqual(testIndexZero, myList[0]);
        }

        //Tests to see if the Array expands when you add an item beyond its current length. Default will be 4
        [TestMethod]
        public void CheckArrayExpansion()
        {
            //Arrange
            int arrayLength = 5;
            MyList myList = new MyList();

            //Act
            myList.Add(1);
            myList.Add(1);
            myList.Add(1);
            myList.Add(1);
            myList.Add(1);

            //Assert
            Assert.AreEqual(arrayLength, myList.Length);
        }
    }
} 