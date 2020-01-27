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
            MyList<string> myList = new MyList<string>();
            string expectedResult = "MaryPaulPoppy";
            string actualResult;

            //Act
            myList.Add("Mary");
            myList.Add("Paul");
            myList.Add("Poppy");
            actualResult = myList.ToString();
        }
    }
}
