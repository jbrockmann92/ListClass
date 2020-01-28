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
            MyList<int> testList = new MyList<int>();
            MyList<int> resultList = new MyList<int>();

            testList.Add(2);
            testList.Add(9);
            testList.Add(1); 
            testList.Add(8);
            testList.Add(2);
            testList.Add(5);

            MyList<int>.IntSort(testList);

            Console.WriteLine(testList);
            Console.ReadLine();

        }
    }
}
