﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                Student student = new Student();

                string[] input = Console.ReadLine().Split();

                student.Name = input[0];
                student.Grades = input.Skip(1).Select(double.Parse).ToList();

                students.Add(student);
            }
            students.Where(s => s.AverageGrade >= 5.00)
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.AverageGrade)
                .ToList()
                .ForEach(s => Console.WriteLine($"{s.Name} -> {s.AverageGrade:f2}"));
            
        }
    }

    class Student
    { 
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade => Grades.Average();
    }
}
