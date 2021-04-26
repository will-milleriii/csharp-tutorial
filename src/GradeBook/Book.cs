﻿using System;
using System.Collections.Generic;
namespace GradeBook
{
    public class Book
    {

        private List<double> grades = new List<double>();
        public string Name;

        public Book(String name)
        {
            Name = name;
            grades = new List<double>();
        }

        public void AddLetterGrade(char letter)
        {
           switch(letter)
           {
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                default:
                    AddGrade(0);  
                    break;
           }
        }

        public void AddGrade(double grade)
        {
            if(grade <=100 && grade >= 0)
            {
                grades.Add(grade);

            } else
            {
                Console.WriteLine("Invalid Value");
            }
        }

        public Statistics GetStatistics()
        {

            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

           for(var i = 0; i < grades.Count; i++)
            {
                result.Low = Math.Min(grades[i], result.Low);
                result.High = Math.Max(grades[i], result.High);
                result.Average += grades[i];
            }
            result.Average /= grades.Count;

            switch(result.Average)
            {
                case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;
                case var d when d >= 80:
                    result.Letter = 'B';
                    break;
                case var d when d >= 70:
                    result.Letter = 'C';
                    break;
                case var d when d >= 60:
                    result.Letter = 'D';
                    break;
                default:
                    result.Letter = 'F';
                    break;    
            }


           return result;
    


        }


    }
}
