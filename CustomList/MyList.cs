using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MyList<T> : IEnumerable where T : IComparable<T>
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
                if (tempCount == Count && item.CompareTo(items[i]) == 0)
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
            for (int i = 0; i < list2.Count; i++)
            {
                resultList.Add(tempList[i]);
                resultList.Add(list2[i]);
            }
            return resultList;
        }

        public void InsertAt()
        {
            //Method to insert an item at a particular index in the list
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
                    if (list1[i].CompareTo(list2[j]) == 0)
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
