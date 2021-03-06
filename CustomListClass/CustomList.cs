﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T>
    {                           
        private T[] _items;             
        private int count;
        private int capacity;
        
        
        public int Count                //As a developer, I want a 'read-only' Count property implemented on the custom-built list class
        {
            get
            {
                return count;
            }
        }
        
        public int Capacity            //As a developer, I want a Capacity property implemented on the custom-built list class
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

        public T this[int index]
        {
            get
            {
                return _items[index]; 
            }
            set
            {
                _items[index] = value;
            }


        }

        public void Add(T valueToAdd)
        {
            if (count < capacity)
            {
                _items[Count] = valueToAdd;
                count++;
            }
            else if(count == capacity)
            {
                capacity += capacity;
                count++;
            }
        }

        //Want to locate and then remove the proper item. 
        public void Remove(T valueToRemove)
        {
            _items[Count] = valueToRemove;
            count--;
        }

        public CustomList()
        {
            count = 0;
            capacity = 6;
            _items = new T[Capacity];
        }

        public override string ToString()
        {
            string newString = "";
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    newString += _items[i].ToString() + "";
                }
            }
            return newString;
        }

        public static CustomList<T> operator+ (CustomList<T> listA, CustomList<T> listB)
        {
            CustomList<T> overloadResult = new CustomList<T>();
            for (int i = 0; i < listA.count; i++)
            {
                overloadResult.Add(listA[i]);
            }
            for (int i = 0; i < listB.count; i++)
            {
                overloadResult.Add(listB[i]);
            }
            return overloadResult;
        }

        public static CustomList<T> operator- (CustomList<T> listA, CustomList<T> listB)
        {
            CustomList<T> overloadMinusResult = new CustomList<T>();
            for (int i = 0; i < listA.count; i++)
            {
                for (int j = 0; j < listB.count; j++)
                {
                    if (listA[i].Equals(listB[j]))
                    {
                        listA.Remove(listA[i]);
                    }
                }
            }
            overloadMinusResult = listA;
            return overloadMinusResult;
        }

        public CustomList<T> Zip(CustomList<T> listA, CustomList<T> listB)
        {
            CustomList<T> zippedList = new CustomList<T>();

            for (int i = 0; i < listB.Count; i++)
            {
                zippedList.Add(listA[i]);
                zippedList.Add(listB[i]);
            }
            return zippedList;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _items.Length; i++)
            {
                yield return _items[i];
            }
        }
    }
}

