using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Practice Book");
            book.AddGrade(89.9);
            book.AddGrade(10.9);
            book.AddGrade(80.9);
            book.GetStatistics();
            var stats = book.GetStatistics();
            //Book book2 = null;
            //book2.AddGrade(89.9);
           // Book.AddGrade(77.0);
            Console.WriteLine("Hello World!");
            Console.WriteLine($" The higher grade number is {stats.High:N2}");
            Console.WriteLine($" The lower grade number is {stats.Low:N2}");
            Console.WriteLine($" The Average grade number is {stats.Average:N2}");
            //var grades = new List<double>() { 12.8, 89.8, 25.7, 69.0, 5.5 };
            //var highGrades = double.MinValue;
            //var lowGrades = double.MaxValue;
            //foreach (var number in grades)
            //{
            //    highGrades = Math.Max(number, highGrades);
            //    lowGrades = Math.Min(number, lowGrades);
            //}
            //Console.WriteLine($" The higher grade number is {highGrades:N2}");
            //Console.WriteLine($" The lower grade number is {lowGrades:N2}");
        }
    }
}
