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
            string expectedResult = "17";
            MyList<int> actualResultList = new MyList<int>();

            //Act

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(7);

            myList1.Add(2);
            myList1.Add(3);
            myList1.Add(6);

            actualResultList = myList - myList1;
            string actualResult = actualResultList.ToString();
            Console.ReadLine();
        }
    }
}
