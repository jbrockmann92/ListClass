using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace ListTests
{
    [TestClass]
    public class ZipperTests
    {
        //Tests if the Zip method puts things in the right order
        [TestMethod]
        public void TestIfZipperWorksInOrder()
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

            resultingList = MyList<int>.Zip(oddList, evenList);
            actualResult = resultingList.ToString();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        //Tests to make sure zip still works if the first list is shorter by 2
        [TestMethod]
        public void TestIfZipperWorksFirstListShorterByTwo()
        {
            //Arrange
            MyList<int> oddList = new MyList<int>();
            MyList<int> evenList = new MyList<int>();
            MyList<int> resultingList = new MyList<int>();
            string actualResult;
            string expectedResult = "123456810";

            //Act
            oddList.Add(1);
            oddList.Add(3);
            oddList.Add(5);

            evenList.Add(2);
            evenList.Add(4);
            evenList.Add(6);
            evenList.Add(8);
            evenList.Add(10);

            resultingList = MyList<int>.Zip(oddList, evenList);
            actualResult = resultingList.ToString();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        //Tests to make sure the Zip method still works if the second list is shorter by 2
        [TestMethod]
        public void TestIfZipperWorksSecondListShorterByTwo()
        {
            //Arrange
            MyList<int> oddList = new MyList<int>();
            MyList<int> evenList = new MyList<int>();
            MyList<int> resultingList = new MyList<int>();
            string actualResult;
            string expectedResult = "12345679";

            //Act
            oddList.Add(1);
            oddList.Add(3);
            oddList.Add(5);
            oddList.Add(7);
            oddList.Add(9);

            evenList.Add(2);
            evenList.Add(4);
            evenList.Add(6);

            resultingList = MyList<int>.Zip(oddList, evenList);
            actualResult = resultingList.ToString();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
