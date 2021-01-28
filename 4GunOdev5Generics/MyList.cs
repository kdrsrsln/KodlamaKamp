using System;
using System.Collections.Generic;
using System.Text;

namespace _4GunOdev5Generics
{
    class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] _tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                items[i] = _tempArray[i];
            }

            items[items.Length - 1] = item;

            Console.WriteLine();
        }
    }
}
