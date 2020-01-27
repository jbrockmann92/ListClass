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
            MyList<int> myList = new MyList<int>();
            MyList<int> myList1 = new MyList<int>();
            MyList<int> expectedResult = new MyList<int>();
            MyList<int> actualResult = new MyList<int>();

            //Act
            expectedResult.Add(1);
            expectedResult.Add(2);
            expectedResult.Add(3);
            expectedResult.Add(4);
            expectedResult.Add(5);
            expectedResult.Add(6);

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            myList1.Add(4);
            myList1.Add(5);
            myList1.Add(6);

            actualResult = (myList + myList1);
            Console.ReadLine();
        }
    }
}
