using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    //Seems like I need to write a way for the indexer to work in order to try any of my tests
    public class MyList<T> where T : IComparable<T>
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
                }
            }
        }

        public T this[int param]
        {
            get 
            {
                if (param <= arrayIndex - 1)
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
            foreach (T item in items)
            {
                string convert = item.ToString();
                convertedToString += convert;
            }
            return convertedToString;
        }
    }
}
