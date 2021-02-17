using System;
using System.Collections.Generic;
using System.Text;

namespace Ocak20
{
    class MyDictionary<TKey,TValue> // where T : class
    {
        TKey[] keys;
        TValue[] values;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tempArrKey = keys;
            keys = new TKey[keys.Length + 1];
            TValue[] tempArrValue = values;
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempArrKey.Length; i++)
            {
                keys[i] = tempArrKey[i];
                values[i] = tempArrValue[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }

        public int Count
        {
            get { return keys.Length; }
        }

        public void List()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + " : " + values[i]);
            }
        }
    }
}
