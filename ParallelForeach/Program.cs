﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelForeach
{
    class Program
    {
      
            static void Main(string[] args)
        {
                string[] colors = { "1. Red", "2. Green", "3. Blue", "4. Yellow", "5. White", "6. Black", "7. Violet", "8. Brown", "9. Orange", "10. Pink" };

                Console.WriteLine("Parallel.ForEach");
                var sw = Stopwatch.StartNew();
                Parallel.ForEach(colors, color =>
                {
                    Console.WriteLine("{0} Thread Id = {1}", color, Thread.CurrentThread.ManagedThreadId);
                    Thread.Sleep(10);
                });
                Console.WriteLine("Parallel.Foreach() execution time ={0} seconds", sw.Elapsed.TotalSeconds);




                Console.WriteLine("\n \n \n Normal Foreach Loop");
                sw = Stopwatch.StartNew();
                foreach (string color in colors)
                {
                    Console.WriteLine("{0} Thread Id = {1}", color, Thread.CurrentThread.ManagedThreadId);
                    Thread.Sleep(10);
                }
                Console.WriteLine("foreach loop execution time = {0} seconds \n", sw.Elapsed.TotalSeconds);


            
        }
    }
}
