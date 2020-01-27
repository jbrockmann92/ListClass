using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace ListTests
{
    [TestClass]
    public class IndexTests
    {
        [TestMethod]
        public void TestIndexerRightLocation()
        {
            //Arrange
            MyList<int> myList = new MyList<int>();
            int expectedResult = 5;
            int actualResult;

            //Act
            myList.Add(3);
            myList.Add(5);
            myList.Add(7);
            actualResult = myList[1];

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
