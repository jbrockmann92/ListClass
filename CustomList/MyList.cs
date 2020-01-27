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
        //Capacity has to be equal to 4
        //I don't think I want to be able to set these. Maybe I do? Just not let the user have access to them?
        private int count;
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
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
            //Feels like there's a better way to do this. Should be able to do it without creating another variable?
            for (int i = 0; i < count; i++)
            {
                if (tempIndex == arrayIndex && item.CompareTo(items[i]) == 0)
                {
                    items[i] = default;
                    arrayIndex--;
                    count--;
                    items[arrayIndex] = items[tempIndex];
                        //Only duplicates, doesn't remove the previous
                }
            }
            //Need to make sure [1] is moved to [0] when 

        }

        public void CreateNewArray()
        {
            T[] tempArray = new T[Capacity];
            tempArray = items;
            //Will this work? Just to copy the array, ora do I need to do a for loop like below?
            int tempCapacity = Capacity - 1;

            Capacity += 4;

            items = new T[Capacity];
            for (int i = 0; i <= tempCapacity; i++)
            {
                items[i] = tempArray[i];
            }
        }

        //Indexer. Needs to have access to Capacity? And/Or arrayIndex?
        public T this[int param]
        {
            get { return items[param]; }
            set { items[param] = value; }
        }
    }
}
