using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T>
    {                           
        private T[] _items;             //Should these be made private? But then our test class would not be accessing them properly?
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
        }

        public T this[int index]
        {
            get
            {
                return Count;
            }

        }

        public CustomList()
        {
            count = 0;
            capacity = 6;
            _items = new T[Capacity];
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

        public void Remove(T valueToRemove)
        {
            _items[Count] = valueToRemove;
            count--;
        }

      


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