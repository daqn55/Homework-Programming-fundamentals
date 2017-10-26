using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _04._Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = File.ReadAllLines("Input.txt");
            File.WriteAllText("Output.txt", "");

            int n = int.Parse(inputs[0]);
            List<Student> students = new List<Student>();
            for (int i = 1; i <= n; i++)
            {
                Student student = new Student();
                string[] input = inputs[i].Split();

                student.Name = input[0];
                student.Grades = input.Skip(1).Select(double.Parse).ToList();

                students.Add(student);
            }
            
            students.Where(s => s.AverageGrade >= 5.00)
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.AverageGrade)
                .ToList()
                .ForEach(s => File.AppendAllText("Output.txt", ($"{s.Name} -> {s.AverageGrade:f2}\r\n")));
            
        }
    }

    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade => Grades.Average();
    }
}