using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    //Seems like I need to write a way for the indexer to work in order to try any of my tests
    public class MyList<T>
    {
        public T[] items;
        int arrayIndex = 0;

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
                capacity = value;
            }
        }
        //The only way I know how to do these is in a different class. Look up syntax??

        public MyList()
        {
            items = new T[4];
        }

        public void Add(T item)
        {
            items[arrayIndex] = item;
            arrayIndex++;

            if (arrayIndex > Capacity)
            {
                CreateNewArray();
            }
        }

        public void Remove(T item)
        {

        }

        public void CreateNewArray()
        {
            T[] tempArray = new T[Capacity];
            tempArray = items;
            int tempCapacity = Capacity;

            Capacity += 4;

            //Function that copies the current array, creates whatever the current array size is +4, and copies that info into the new array starting at index 0

            //How do I copy the current array into the tempArray?

            items = new T[Capacity];
            items = tempArray;
            for (int i = 0; i <= tempCapacity; i++)
            {
                items[tempCapacity] = tempArray[tempCapacity];
            }
            //Not sure if this is turning it back into a smaller array of only 4?
            //How to copy info, but leave array size the same?
        }
    }
}
