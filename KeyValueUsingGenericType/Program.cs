﻿using System;
using System.Collections.Generic;

namespace KeyValueUsingGenericType
{
    class Program
    {
        static void Main()
        {
            var d = new MyDictionary<object>();
            try
            {
                Console.WriteLine(d["Cats"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            d["Cats"] = 42;
            d["Dogs"] = 17;
            Console.WriteLine($"{(int)d["Cats"]}, {(int)d["Dogs"]}");
        }
    }
}
