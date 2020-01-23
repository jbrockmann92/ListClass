using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace ListTests
{
    [TestClass]
    public class RemoveTests
    {
        //Tests [0] after removing a number from the list
        [TestMethod]
        public void CheckZeroIndexAfterRemove()
        {
            //Arrange
            MyList myList = new MyList();

            //Act
            myList.Add(5);
            myList.Add(20);
            myList.Remove(20);

            //Assert
            Assert.AreEqual(5, myList[0]);
        }

        //Tests [0] after removing the first item in the list
        [TestMethod]
        public void CheckOneIndexAfterRemove()
        {
            //Arrange
            MyList myList = new MyList();

            //Act
            myList.Add(5);
            myList.Add(20);
            myList.Remove(5);

            //Assert
            Assert.AreEqual(20, myList[0]);
        }
    }
}
