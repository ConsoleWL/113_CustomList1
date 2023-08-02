using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        //Member Variables (HAS A)
        private T[] items;
        private int capacity;
        private int count;

        //Constructor
        public CustomList()
        {

            count = 0;
            capacity = 4;
            items = new T[capacity];
        }

        public int Capacity { get => capacity;}
        public int Count { get => count;}

        //Member Methods (CAN DO)
        public void Add(T item)
        {
            int temp = 0;
            while (true)
            {
                if (count == capacity)
                {
                    T[] itemsTemp = new T[capacity * 2];
                    for (int i = 0; i < capacity; i++)
                    {
                        itemsTemp[i] = items[i];
                    }
                    capacity *= 2;
                    items = itemsTemp;
                    //items = new T[capacity * 2];
                }

                if (items[temp] == null)
                {
                    items[temp] = item;
                    count++;
                    break;
                }
                else
                {
                    temp++;
                }
            }
        }

        // Indexers //how I would check a if(index <= 0 && index <= count)
        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }

                            //"hello5"
        public bool Remove(T item)
        {
            //for (int i = 0; i < count; i++)
            //{
            //    if (items[i] == item) 
            //    {
            //        items[i] == null;

            //        // then we need to create a new array and shift everything in there after that index was removed

            //    }
            //}

            return false;
        }
        //If 'item' exists in the 'items' array, remove its first instance
        //Any items coming after the removed item should be shifted down so there is no empty index.
        //If 'item' was removed, return true. If no item was removed, return false.

        public override string ToString()
        {
            string listToString = "";

            for (int i = 0; i < count; i++)
            {
                listToString += $"{items[i]}" + " ";
            }
            return listToString;
        }

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> that contains all items from firstList and all items from secondList 
            return null;
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> with all items from firstList, EXCEPT any items that also appear in secondList
            return null;
        }


    }
}
