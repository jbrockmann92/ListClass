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

        }
    }
}
