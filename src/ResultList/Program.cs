using System;
using System.Collections.Generic;

namespace ResultList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Do some mathematical task;
            var x = 34.7;
            var y = 40;
            var result = x + y;
            Console.WriteLine($"Sum of two num is {result}.");
            // Do some exercise with array
            var numbers = new[] { 6.7, 8.9, 10.6, 7.9 };
            //number[0] = 12.4;
            //number[1] = 7.5;
            //number[2] = 10.5;
            //var res = numbers[0];
            //res = numbers[0] + numbers[1] + numbers[2];
            var res = 0.0;
            foreach (var number in numbers)
            {
                res += number;
                Console.WriteLine($" Sum of the arrays = {res:N3}");
            }
            // create a list of array and calculate the average of the array list.
            var arr = new List<double>() { 12.4, 5, 7, 6, 9, 9, 0, 23, 8 };
            arr.Add(13.9);
            var sum = 0.0;
           

            foreach (var number in arr)
            {
                sum += number;
            }
            sum /= arr.Count;
            Console.WriteLine($" the average of the array is {sum:N3}!");

            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else 
            {
                Console.WriteLine("Hello!");
            }

         }
    }
}
