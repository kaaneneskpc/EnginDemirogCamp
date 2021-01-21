using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryÖdev
{
    class MyDict<TKey,TValue>
    {
        TKey[] keys;
        TValue[] values;
        public MyDict()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key,TValue value)
        {
             TKey[] tempKey = keys;
            TValue[] tempValue = values;
            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempValue[i];

            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
        public TKey[] Key
        {
            get { return keys; }
        }

        public TValue[] Value
        {
            get { return values; }
        }
    }
}
