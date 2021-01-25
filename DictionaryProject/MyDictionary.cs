using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryProject
{
    class MyDictionary<TKey, TValue>
    {
        public TKey[] keys;
        public TValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tempArray = keys;
            TValue[] tempArray2 = values;

            keys = new TKey[keys.Length + 1];

            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                keys[i] = tempArray[i];
                values[i] = tempArray2[i];
            }

            values[values.Length - 1] = value;
            keys[keys.Length - 1] = key;
            
        }

        public void Show()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + " " + values[i]);
            }
        }
    }
}
