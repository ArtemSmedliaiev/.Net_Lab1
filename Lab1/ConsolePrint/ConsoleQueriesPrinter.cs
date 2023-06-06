using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.ConsolePrint
{
    internal class ConsoleQueriesPrinter
    {
        public void Print<TValue>(string message, IEnumerable<TValue> singleCollectionQuery)
        {
            Console.Clear();
            Console.WriteLine($"Ви обрали {message}\n");
            foreach (TValue element in singleCollectionQuery)
            {
                Console.WriteLine(element);
            }
        }

        public void Print<TKey, TValue>(string message, Dictionary<string, List<string>> multy)
        {
            Console.Clear();
            Console.WriteLine($"Ви обрали {message}\n");
            foreach (KeyValuePair<string, List<string>> pair in multy)
            {
                Console.WriteLine(pair.Key);
                foreach (string element in pair.Value)
                {
                    Console.WriteLine("\t" + element);
                }
                Console.WriteLine();
            }
        }

        public void Print<TKey, TValue>(string message, Dictionary<TKey, List<TValue>> multy)
        {
            Console.Clear();
            Console.WriteLine($"Ви обрали {message}\n");
            foreach (KeyValuePair<TKey, List<TValue>> pair in multy)
            {
                Console.WriteLine(pair.Key);
                foreach (TValue element in pair.Value)
                {
                    Console.WriteLine("\t" + element);
                }
                Console.WriteLine();
            }
        }
    }
}
