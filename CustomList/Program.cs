﻿using System;
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
            MyList<int> myList1 = new MyList<int>();
            MyList<int> myList2 = new MyList<int>();
            MyList<int> actualResultList = new MyList<int>();

            myList1.Add(1);
            myList1.Add(2);
            myList1.Add(2);
            myList1.Add(5);
            //myList1 { 1, 2, 2, 5 }

            myList2.Add(2);
            myList2.Add(5);
            myList2.Add(6);
            myList2.Add(3);
            //myList2 { 2, 5, 6, 3 }

            actualResultList = myList1 - myList2;
            //actualResultList will be: MyList<int>() { 1, 2 }
            //Minus operator has removed only one of the 2 ints, and the only 5 int
            
        }
    }
}
