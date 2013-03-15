using System;
using System.Collections.Generic;
using System.Text;

namespace exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DummyCollection<int> foo = new DummyCollection<int>();
            foo.AddItem(5);
            foo.AddItem(1337);
            foo.AddItem(1);
            foo.AddItem(15);
            foo.AddItem(-3);
            foo.AddItem(42);
            foo.AddItem(41);

            Console.WriteLine("Before the collection is sorted:");
            foreach (var item in foo)
            {
                Console.WriteLine(item);
            }

            foo.Sort();

            Console.WriteLine("\nAfter the collection is sorted:");
            foreach (var item in foo)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nExplicit use of the enumerator:");
            IEnumerator<int> enumerator = foo.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            //The enumerator can be accessed in that way if it's public
            //DummyCollection<int>.DummyEnumerator<int> bar = new DummyCollection<int>.DummyEnumerator<int>(foo);
        }
    }
}
