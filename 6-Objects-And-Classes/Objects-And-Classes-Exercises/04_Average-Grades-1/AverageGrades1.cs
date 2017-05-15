using System;
using System.Linq;

public class AverageGrades
{
    public static void Main()
    {
        Student[] students = ReadStudents();

        var bestStudents = students
            .Where(g => g.AverageGrade >= 5)
            .OrderBy(x => x.Name)
            .ThenByDescending(g => g.AverageGrade);

        foreach (var st in bestStudents)
        {
            Console.WriteLine("{0} -> {1:F2}", st.Name, st.AverageGrade);
        }
    }

    static Student[] ReadStudents()
    {
        int n = int.Parse(Console.ReadLine());
        Student[] students = new Student[n];

        for (int i = 0; i < n; i++)
        {
            students[i] = ReadStudent();
        }

        return students;
    }

    static Student ReadStudent()
    {
        string[] studentInfo = Console.ReadLine().Split(' ');

        Student student = new Student();
        double[] grades = new double[studentInfo.Length - 1];

        for (int i = 1; i < studentInfo.Length; i++)
        {
            grades[i - 1] = double.Parse(studentInfo[i]);
        }

        student.Name = studentInfo[0];
        student.GradesList = grades;
        student.AverageGrade = student.AverageGr(grades);

        return student;
    }
}

public class Student
{
    public string Name { get; set; }
    public double[] GradesList { get; set; }
    public double AverageGrade { get; set; }

    public double AverageGr(double[] GradesList)
    {
        double gradesSum = 0;

        for (int i = 0; i < GradesList.Length; i++)
        {
            gradesSum += GradesList[i];
        }

        return gradesSum / GradesList.Length;
    }
}