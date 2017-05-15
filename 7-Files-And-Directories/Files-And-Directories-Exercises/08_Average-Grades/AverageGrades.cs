using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class AverageGrades
{
    public static void Main()
    {
        File.WriteAllText("Input.txt", "");
        File.WriteAllText("Output.txt", "");

        List<Student> students = ReadStudents();
        PrintStudents(students);
    }

    static void PrintStudents(List<Student> students)
    {
        var orderedStudents = students
            .Where(s => s.AverageGrade >= 5)
            .OrderBy(x => x.Name)
            .ThenByDescending(g => g.AverageGrade);

        foreach (var entry in orderedStudents)
        {
            File.AppendAllText("Output.txt", $"{entry.Name} -> {entry.AverageGrade:F2}\r\n");
            Console.WriteLine("{0} -> {1:F2}", entry.Name, entry.AverageGrade);
        }
    }

    static List<Student> ReadStudents()
    {
        int n = int.Parse(Console.ReadLine());
        List<Student> students = new List<Student>();

        File.AppendAllText("Input.txt", n.ToString() + Environment.NewLine);

        for (int i = 0; i < n; i++)
        {
            Student student = ReadStudent();
            students.Add(student);
        }

        return students;
    }

    static Student ReadStudent()
    {
        string studentInfoStr = Console.ReadLine();
        string[] studentInfo = studentInfoStr.Split(' ');
        string name = studentInfo[0];
        List<double> grades = new List<double>();

        File.AppendAllText("Input.txt", studentInfoStr + Environment.NewLine);
        
        for (int i = 1; i < studentInfo.Length; i++)
        {
            grades.Add(double.Parse(studentInfo[i]));
        }

        Student student = new Student();
        student.Name = name;
        student.Grades = grades;

        return student;
    }
}

public class Student
{
    public string Name { get; set; }
    public List<double> Grades { get; set; }
    public double AverageGrade
    {
        get
        {
            return Grades.Average();
        }
    }
}

