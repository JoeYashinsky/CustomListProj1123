using System;
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

        //public CustomList<T> Zip(CustomList<T> zipListOne, CustomList<T> zipListTwo)
        //{
        //    CustomList<T> zippedList = new CustomList<T>(zipListOne + zipListTwo);
        //    for (int z = 0; z < ; z++)
        //    {
        //        zippedList.Add
        //        }

        //}




    }
}

//public class CustomList<T>
//{
//    T[] _items;
//    public int Count;
//    public int Capacity;


//    public CustomList()
//    {
//        Count = 0;
//        Capacity = 4;
//        _items = new T[Capacity];
//    }


//    public void Add(T valueToAdd)
//    {
//        _items[Count] = valueToAdd;
//        Count++;

//    }
//}