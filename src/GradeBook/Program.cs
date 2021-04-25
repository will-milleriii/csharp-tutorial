using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Main Gradebook");
            book.AddGrade(81.6);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            book.ShowStatistics();

    
        }
    }
}
