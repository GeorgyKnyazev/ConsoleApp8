using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> buyers = new Queue<int>();

            buyers.Enqueue(1);
            buyers.Enqueue(2);
            buyers.Enqueue(3);                
            buyers.Enqueue(4);

            int moneyInStore = 0;

            while (buyers.Count > 0)
            {
                WriteBuyResult (moneyInStore, buyers);

                moneyInStore = moneyInStore + buyers.Dequeue();
                Console.Clear();
            }

            WriteBuyResult (moneyInStore, buyers);            
        }

        static void WriteBuyResult(int moneyInStore, Queue<int> buyers)
        {
            Console.WriteLine("В кассе " + moneyInStore + " монет");
            Console.WriteLine("В очереди " + buyers.Count + "человек");
            Console.ReadKey();
        }
    }
}
