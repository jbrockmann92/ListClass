using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {

            //Arrange
            MyList<int> myList = new MyList<int>();
            int expectedResult = 5;
            int actualResult;

            //Act
            myList.Add(5);
            myList.Add(5);
            myList.Remove(5);
        }
    }
}
