using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MyList<T> : IEnumerable
    {
        public T[] items;
        bool isRemoveFound;

        private int capacity = 4;
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }

        private int count;
        public int Count
        {
            get
            {
                return count;
            }
        }

        public MyList()
        {
            items = new T[4];
        }

        public void Add(T item)
        {
            if (Count > Capacity - 1)
            {
                CreateNewArray();
            }

            items[Count] = item;
            count++;
        }

        public void Remove(T item)
        {
            int tempCount = Count;
            for (int i = 0; i < tempCount; i++)
            {
                if (tempCount == Count && item.Equals(items[i]))
                {
                    isRemoveFound = true;
                    items[i] = default;
                    count--;
                }
                MoveDownIndex(i);
            }
        }

        public void CreateNewArray()
        {
            T[] tempArray = new T[Capacity];
            tempArray = items;
            int tempCapacity = Capacity - 1;

            Capacity += 4;

            items = new T[Capacity];
            for (int i = 0; i <= tempCapacity; i++)
            {
                items[i] = tempArray[i];
            }
        }

        public void MoveDownIndex(int variable)
        {
            if (isRemoveFound == true)
            {
                for (int i = variable; i < Count; i++)
                {
                    items[i] = items[i + 1];
                    isRemoveFound = false;
                }
            }
        }

        public override string ToString()
        {
            string convertedToString = "";
            for (int i = 0; i < Count; i++)
            {
                string convert = items[i].ToString();
                convertedToString += convert;
            }
            return convertedToString;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return items[i];
            }
        }

        public static MyList<T> Zip(MyList<T> list1, MyList<T> list2)
        {
            MyList<T> resultList = new MyList<T>();
            MyList<T> tempList = new MyList<T>();
            tempList = list1;
            for (int i = 0; i < list2.Count || i < list1.Count; i++) //Can't do either list1 or list2 here
            {
                if ((i < list1.Count) && (i < list2.Count))
                {
                    resultList.Add(tempList[i]);
                    resultList.Add(list2[i]);
                }
                else if ((list1.Count > list2.Count) && (i < list1.Count))
                {
                    resultList.Add(list1[i]);
                }
                else if ((list2.Count > list1.Count) && (i < list2.Count))
                {
                    resultList.Add(list2[i]);
                }
            }

            return resultList;
        }

        //Here using the QuickSort algorithm
        public static void Exchange(MyList<int> myList, int m, int n)
        {
            int temporary;

            temporary = myList[m];
            myList[m] = myList[n];
            myList[n] = temporary;
        }

        public static void IntSort(MyList<int> myList, int zero, int countMinus)
        {
            int beginning, end;
            int x;

            beginning = zero;
            end = countMinus;

            x = myList[(zero + countMinus) / 2];
            while (true)
            {
                while (myList[beginning] < x)
                    beginning++;
                while (x < myList[end])
                    end--;
                if (beginning <= end)
                {
                    Exchange(myList, beginning, end);
                    beginning++;
                    end--;
                }
                if (beginning > end)
                    break;
            }
            if (zero < end)
                IntSort(myList, zero, end);
            if (beginning < countMinus)
                IntSort(myList, beginning, countMinus);
        }

        public static void IntSort(MyList<int> myList)
        {
            IntSort(myList, 0, myList.Count - 1);
        }

        public static MyList<T> operator +(MyList<T> list1, MyList<T> list2)
        {
            MyList<T> resultList = new MyList<T>();
            for (int i = 0; i < list1.Count; i++)
            {
                resultList.Add(list1[i]);
            }

            for (int i = 0; i < list2.Count; i++)
            {
                resultList.Add(list2[i]);
            }

            return resultList;
        }

        public static MyList<T> operator -(MyList<T> list1, MyList<T> list2)
        {

            for (int i = 0; i < list1.Count; i++)
            {
                for (int j = 0; j < list2.Count; j++)
                {
                    if (list1[i].Equals(list2[j]))
                    {
                        list1.Remove(list1[i]);
                    }
                }
            }
            return list1;
        }

        public T this[int index]
        {
            get
            {
                if (index <= Count)
                {
                    return items[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set { items[index] = value; }
        }
    }
}
