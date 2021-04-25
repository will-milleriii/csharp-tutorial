using System;
using System.Collections.Generic;
namespace GradeBook
{
    public class Book
    {

        private List<double> grades = new List<double>();
        private string name;

        public Book(String name)
        {
            this.name = name;
            grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {

            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach (var grade in grades)
            {
                lowGrade = Math.Min(grade, lowGrade);
                highGrade = Math.Max(grade, highGrade);

                result += grade;
            }

            result = result / grades.Count;
            Console.WriteLine($"The lowest grade is {lowGrade}");
            Console.WriteLine($"The highest grade is {highGrade}");
            System.Console.WriteLine($"The average result is {result:N1}");


        }


    }
}
