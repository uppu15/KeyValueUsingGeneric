using System;
using System.Collections.Generic;
using System.Text;

namespace KeyValueUsingGenericType
{
    public struct KeyValue<T>
    {
        public KeyValue(string key, T value)
        {
            this.Key = key;
            this.Value = value;
        }
        public readonly string Key;
        public readonly T Value;
    }

    public class MyDictionary<T>
    {
        int count = 0;

        KeyValue<T>[] keyValueArray = new KeyValue<T>[10];

        public T this[string index]
        {
            get
            {
                for (int i = 0; i < keyValueArray.Length; i++)
                {
                    if (keyValueArray[i].Key == index)
                        return keyValueArray[i].Value;
                }
                throw new KeyNotFoundException(index);
            }
            set
            {
                for (int i = 0; i < keyValueArray.Length; i++)
                {
                    if (keyValueArray[i].Key == index)
                    {
                        keyValueArray[i] = new KeyValue<T>(index, value);
                        return;
                    }
                }
                for (int i = 0; i < keyValueArray.Length; i++)
                {
                    if (keyValueArray[i].Key == null)
                    {
                        keyValueArray[i] = new KeyValue<T>(index, value);
                        count++;
                        return;
                    }
                }
            }
        }
    }

}
