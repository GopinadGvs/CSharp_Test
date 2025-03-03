using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp_Test
{
    internal class MultiThreading
    {
        public static void MultiThreadingTest()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine("Regular foreach loop:");
            foreach (var num in numbers)
            {
                Process(num);
            }

            Console.WriteLine("\nParallel.ForEach loop:");
            Parallel.ForEach(numbers, num =>
            {
                Process(num);
            });

            Console.WriteLine("Done!");
        }

        static void Process(int num)
        {
            Console.WriteLine($"Processing {num} on thread {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(500); // Simulating work
        }
    }


    class MultipleThreads
    {
        public static void PrintNumbers(object id)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Thread {id}: {i}");
                Thread.Sleep(500); // Simulating work
            }
        }

        public static void MultipleThreadsTest()
        {
            // Creating and starting multiple threads
            Thread thread1 = new Thread(PrintNumbers);
            Thread thread2 = new Thread(PrintNumbers);

            thread1.Start(1);
            thread2.Start(3);

            // Main thread continues execution
            Console.WriteLine("Main thread execution continues...");

            // Wait for threads to complete
            thread1.Join();
            thread2.Join();

            Console.WriteLine("All threads completed.");
        }
    }
}
