using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09Enums
{
    class Program
    {
        enum WeekDays
        {
            Monday=1,
            Tuseday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        };


        static void Main(string[] args)
        {
            int x = (int)WeekDays.Monday;
            int y = (int)WeekDays.Sunday;

            Console.WriteLine("Mon = {0}", x);
            Console.WriteLine("Sun = {0}", y);

            Console.Write("\n\nPress any Key To Continue...");
            Console.ReadKey();
        }
    }
}
