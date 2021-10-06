using System;
using System.Collections.Generic;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new ConcreteCollection
            {
                Collection = new List<int>()
                {
                    1,
                    2,
                    3,
                    4,
                    5
                }
            };


            Console.WriteLine("-----[ ForwardsIterator ]-----");
            foreach (var x in collection)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\n-----[ BackwardsIterator ]-----");

            collection.SetIterator(new BackwardsIterator(collection));

            foreach (var x in collection)
            {
                Console.WriteLine(x);
            }
        }
    }
}
