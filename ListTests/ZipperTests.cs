using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace ListTests
{
    [TestClass]
    public class ZipperTests
    {
        //Tests 
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            MyList<int> oddList = new MyList<int>();
            MyList<int> evenList = new MyList<int>();
            MyList<int> resultingList = new MyList<int>();
            string actualResult;
            string expectedResult = "123456";

            //Act
            oddList.Add(1);
            oddList.Add(3);
            oddList.Add(5);

            evenList.Add(2);
            evenList.Add(4);
            evenList.Add(6);

            resultingList = oddList.Zip(evenList);
            actualResult = resultingList.ToString();
            //.Zip(parameter)

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
