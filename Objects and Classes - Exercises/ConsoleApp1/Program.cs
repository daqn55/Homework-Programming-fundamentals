using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _08._Mentor_Group
{
    class Student
    {
        public List<string> Comments { get; set; }
        public List<DateTime> Dates { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string dataStudents = Console.ReadLine();
            SortedDictionary<string, Student> dataOfStudents = new SortedDictionary<string, Student>();

            while (dataStudents != "end of dates")
            {
                string[] nameAndDates = dataStudents.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                Student student = new Student();
                student.Dates = new List<DateTime>();

                for (int i = 1; i < nameAndDates.Length; i++)
                {
                    student.Dates.Add(DateTime.ParseExact(nameAndDates[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                }
                if (dataOfStudents.ContainsKey(nameAndDates[0]))
                {
                    dataOfStudents[nameAndDates[0]].Dates.InsertRange(0, student.Dates);
                }
                else
                {
                    dataOfStudents.Add(nameAndDates[0], student);
                }

                dataStudents = Console.ReadLine();
            }

            string dataCommentsOfStudents = Console.ReadLine();
            string[] nameAndComment1 = dataCommentsOfStudents.Split('-');
            dataOfStudents[nameAndComment1[0]].Comments = new List<string>();
            int count = 0;
            while (dataCommentsOfStudents != "end of comments")
            {
                string[] nameAndComment = dataCommentsOfStudents.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                if (dataOfStudents.ContainsKey(nameAndComment[0]))
                {
                    //if (count == 0)
                    // {
                    //    dataOfStudents[nameAndComment[0]].Comments = new List<string>();
                    //}
                    if (nameAndComment.Length - 1 > 0)
                    {
                        dataOfStudents[nameAndComment[0]].Comments.Add(nameAndComment[1]);
                    }
                }
                dataCommentsOfStudents = Console.ReadLine();
                count++;
            }

            foreach (var item in dataOfStudents)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine("Comments:");
                if (item.Value.Comments != null)
                {
                    foreach (var comment in item.Value.Comments)
                    {
                        Console.WriteLine($"- {comment}");
                    }
                }
                Console.WriteLine("Dates attended:");
                if (item.Value.Dates != null)
                {
                    foreach (var dates in item.Value.Dates.OrderBy(x => x.Date))
                    {
                        Console.WriteLine($"-- {dates.ToString("dd/MM/yyyy")}");
                    }
                }
            }
        }
    }
}
