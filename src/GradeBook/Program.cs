using System;
using System.Collections.Generic;
using System.Globalization;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new List<double>() {12.5, 32.2, 44.9, 21.7};
            grades.Add(55.4);
            var result = 0.0;

            foreach (var num in grades)
            {
                result += num;
            }
            result /= grades.Count;
            Console.WriteLine(result:N1);
        }
    }
}
