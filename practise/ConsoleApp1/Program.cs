using System;
using System.Collections.Generic;
namespace GenericsDemo
{
    class program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 2.1, 2.2, 2.3, 2.4 };
            char[] charArray = { 'A', 'R', 'J', 'U', 'N' };

            program.toPrint<int>(intArray);
            program.toPrint<double>(doubleArray);
            program.toPrint<char>(charArray);
        }
       
        
        public static void toPrint<T>(T[] InputArray)
        {
            foreach (var element in InputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("---------------");
        }
    }
    
}
