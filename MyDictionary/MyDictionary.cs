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
            TValue[] tempValue = values;

            keys = new TKeys[tempKey.Length + 1];
            values = new TValue[tempValue.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempValue[i];
            }

            keys[keys.Length - 1] = key;          
            values[keys.Length - 1] = value;
        }
        public void List()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Numara:{0} - İsim:{1}", keys[i], values[i]);
            }
        }
    }
}

