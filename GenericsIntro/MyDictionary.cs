using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    
    
    class MyDictionary<TKey,TValue>
    {
        TKey[] keys;
        TValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value) {

            TKey[] tempKeys = keys;
            keys = new TKey[keys.Length+1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }

            keys[keys.Length - 1] = key;



            TValue[] tempValues = values;
            values = new TValue[values.Length+1];

            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }

            values[values.Length - 1] = value;


        }

        public int Length() {
          return keys.Length;
        }



    }
}
