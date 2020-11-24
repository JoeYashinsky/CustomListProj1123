using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T>
    {
        T[] _items;
        public int Count;
        public int Capacity;
        
        public T this[int index]
        {get
            {
                return Count;
            }

        }
        

        public CustomList()
        {
            Count = 0;
            Capacity = 6;
            _items = new T[Capacity];
        }

        public void Add(T valueToAdd)
        {
            _items[Count] = valueToAdd;
            Count++;
        }
        public void Remove(T valueToAdd)
        {
            _items[Count] = valueToAdd;
            Count--;
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