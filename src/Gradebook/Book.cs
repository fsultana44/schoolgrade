using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            /*var highGrades = double.MinValue;
            var lowGrades = double.MaxValue;*/
            foreach (var grade in grades)
            {
                /*highGrades = Math.Max(number, highGrades);
                lowGrades = Math.Min(number, lowGrades);*/
                result.Low = Math.Max(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average = Math.Max(grade, result.Average);

            }
            result.Average /= grades.Count;
            return result;
            //Console.WriteLine($" The higher grade number is {result.High:N2}");
            //Console.WriteLine($" The lower grade number is {result.Low:N2}");
            //Console.WriteLine($" The Average grade number is {result.Average:N2}");
        }
         public List<double> grades;
         public string Name;
    }
}
