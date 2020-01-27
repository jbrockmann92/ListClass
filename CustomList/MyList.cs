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
        public T MaxValue;
        public T[] items;
        int arrayIndex;
        bool isFound;

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
        //The only way I know how to do these is in a different class. Look up syntax??

        public MyList()
        {
            items = new T[4];
            arrayIndex = 0;
        }

        public void Add(T item)
        {
            if (arrayIndex > Capacity - 1)
            {
                CreateNewArray();
            }

            items[arrayIndex] = item;
            arrayIndex++;
            count++;
        }

        public void Remove(T item)
        {
            int tempIndex = arrayIndex;
            int tempCount = Count;
            //Feels like there's a better way to do this. Should be able to do it without creating another variable?
            for (int i = 0; i < tempCount; i++)
            {
                if (tempIndex == arrayIndex && item.CompareTo(items[i]) == 0)
                    //Tests to make sure only one item is removed. If an item has been removed, it will not go through again and remove any duplicates
                {
                    isFound = true;
                    items[i] = default;
                    arrayIndex--;
                    count--;
                    //Are those both the same always? I think I can get rid of arrayIndex and just use (count - 1)
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
            if (isFound == true)
            {
                for (int i = variable; i < Count; i++)
                {
                    items[i] = items[i + 1];
                    isFound = false;
                }
            }
        }

        public T this[int param]
        {
            get 
            {
                if (param <= arrayIndex)
                {
                    return items[param];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set { items[param] = value; }
        }

        public override string ToString()
        {
            string convertedToString = "";
            //Want a foreach loop that converts each item to a string and adds it to the current string. Should be somewhat easy
            for (int i = 0; i < Count; i++)
            {
                string convert = items[i].ToString();
                convertedToString += convert;
            }
            return convertedToString;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        //Need to figure out why this is here and why it gives me an error if it's not

        //Overload + operator. Should just be using the Add method
        public static MyList<T> operator +(MyList<T> list1, MyList<T> list2)
        {
            MyList < T > resultList = new MyList<T>();

            //Seems like I need to iterate over the second list and use the Add method for each item in the list. Nice that each instantiation has its own count property
            //All in the same class, so don't have to worry about public and private as long as scope is properly set
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

        //Overload - operator. Should just be using the Remove method

        public static MyList<T> operator -(MyList<T> list1, MyList<T> list2)
        {
            
            for (int i = 0; i < list1.Count; i++)
            {
                for (int j = 0; j < list2.Count; j++)
                {
                    if (list1[i].CompareTo(list2[j]) == 0)
                    {
                        list1.Remove(list1[i]);
                        //When I call Remove() here, it ends up doing too much. Just want it to take out the one from the one spot.
                        //Fixed by setting isFound = false; again after it finds the matching item. Should have been there in the first place
                    }
                }
            }
            return list1;
        }

        //Zip two lists together. Should be something with the Add method
    }
}
