using System;
using System.Collections.Generic;
using System.Text;

namespace _4GunOdev5Dictionary
{
    class MyDictionary<TKey,TValue>
    {
        private TKey[] keys;
        private TValue[] values;

        public MyDictionary()
        {
            // Creates empty arrays for Keys and Values
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            // Copies arrays to temp ones
            TKey[] tempKeys = keys;
            TValue[] tempValues = values;

            // Creates new bigger arrays
            keys = new TKey[keys.Length +1];
            values = new TValue[values.Length +1];

            // Copy Back from temp to new array
            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }

            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }

            // Adds new items to arrays
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

            Console.WriteLine("Key : " + key + " and Value : " + value + " added!" );

        }
    }
}
