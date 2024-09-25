using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    public class MyDictionary<TKeys, TValue>
    {
        TKeys[] keys;
        TValue[] values;

        public MyDictionary()
        {
            keys = new TKeys[0];
            values = new TValue[0];
        }

        public void Add(TKeys key, TValue value)
        {
            TKeys[] tempKey = keys;

            keys = new TKeys[tempKey.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
            }

            keys[keys.Length - 1] = key;

            TValue[] tempValue = values;

            values = new TValue[tempValue.Length + 1];

            for (int i = 0; i < tempValue.Length; i++)
            {
                values[i] = tempValue[i];
            }

            values[keys.Length - 1] = value;
        }
        public void List()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Numara:{0} - İsim:{1}", keys[i],values[i]);
            }
        }
    }
}

