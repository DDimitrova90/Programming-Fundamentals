using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace _10.StudentGroups
{
    class StudentGroups
    {
        static void Main()
        {
            PrintResults(CreateGroups());
        }

        static List<Town> CreateGroups()
        {
            // Read the input and create the List of Towns
            List<Town> towns = new List<Town>();
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                    break;

                if (command.Contains("=>"))
                {
                    // New town input
                    // ex: Plovdiv => 5 seats (where 5 is the max capacity of a group)

                    // Don't use Regex because we haven't learned it yet
                    string[] townInfo = command.Split(new string[] { "=>" }, StringSplitOptions.RemoveEmptyEntries);
                    string townName = townInfo[0].Trim();
                    int groupCapacity = int.Parse(townInfo[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).First());

                    towns.Add(new Town(townName, groupCapacity));
                }
                else
                {
                    // a student is entered
                    // ex: Maya | yumcake@abv.bg | 3-Sep-2016
                    string[] studentInfo = command.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                    string studentName = studentInfo[0].Trim();
                    string studentEmail = studentInfo[1].Trim();
                    string regDateStr = studentInfo[2].Trim();
                    DateTime regDate = DateTime.ParseExact(regDateStr, "d-MMM-yyyy", CultureInfo.InvariantCulture);

                    towns[towns.Count - 1].AddStudent(new Student(studentName, studentEmail, regDate));
                }
            }

            return towns;
        }
        static void PrintResults(List<Town> towns)
        {
            StringBuilder output = new StringBuilder();
            int groupCount = 0;

            foreach (var town in towns.OrderBy(town => town.Name))
            {
                var orderedStudentEmails = town
                    .Students
                    .OrderBy(student => student.RegistrationDate)
                    .ThenBy(student => student.Name)
                    .ThenBy(student => student.Email)
                    .Select(student => student.Email);
                var orderedStudentsInGroups = splitList(orderedStudentEmails.ToList(), town.GroupCapacity);
                groupCount += orderedStudentsInGroups.Count;
                // print each student group
                foreach (List<string> studentsInGroup in orderedStudentsInGroups)
                {
                    output.AppendLine($"{town.Name} => {string.Join(", ", studentsInGroup)}");
                }
            }

            Console.WriteLine($"Created {groupCount} groups in {towns.Distinct().ToList().Count} towns:");
            Console.WriteLine(output.ToString());
        }

        public static List<List<string>> splitList(List<string> students, int groupSize)
        {
            // group the students into groups of groupSize
            var groupedStudents = new List<List<string>>();

            for (int i = 0; i < students.Count; i += groupSize)
            {
                groupedStudents.Add(students.GetRange(i, Math.Min(groupSize, students.Count - i)));
            }

            return groupedStudents;
        }
    }

    class Town
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public int GroupCapacity;

        public Town(string name, int groupCapacity)
        {
            this.Name = name;
            this.GroupCapacity = groupCapacity;  // how much students one group can hold
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            this.Students.Add(student); // add the student
        }
    }

    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }

        public Student(string name, string email, DateTime regDate)
        {
            this.Name = name;
            this.Email = email;
            this.RegistrationDate = regDate;
        }
    }
}