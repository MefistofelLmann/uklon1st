using System;
using System.Collections;

namespace uklon4th
{
    
    class Program
    {
       
        static void Main(string[] args)
        {
            
            try
            {
                int[] a = new int[sizeof(int) * 536870911];
            }
            catch (OutOfMemoryException exp) { Console.WriteLine("Out of memory: "+exp.Message); }
        }
    }
}
