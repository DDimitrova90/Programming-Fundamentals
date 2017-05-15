using System;
using System.Collections.Generic;

class MentorGroup
{
    static void Main()
    {
        SortedDictionary<string, Dictionary<string, List<string>>> students = new SortedDictionary<string, Dictionary<string, List<string>>>();

        // read dates
        while (true)
        {
            string command = Console.ReadLine();
            if (command == "end of dates")
                break;

            string[] dateInfo = command.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string studentName = dateInfo[0];
      
            List<string> dates = new List<string>();
            for (int i = 1; i < dateInfo.Length; i++)
            {
                dates.Add(dateInfo[i]);
            }

            if (!students.ContainsKey(studentName))
            {
                students[studentName] = new Dictionary<string, List<string>>() { { "dates", new List<string>() }, { "comments", new List<string>() } };
            }

            students[studentName]["dates"].AddRange(dates); // add the dates
        }

        // read comments
        while (true)
        {
            string command = Console.ReadLine();
            if (command == "end of comments")
                break;

            string[] commentInfo = command.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            string studentName = commentInfo[0];

            if (!students.ContainsKey(studentName))
                continue;  // skip line if we don't have the student registered
            string comment = commentInfo[1];


            // add the comment
            students[studentName]["comments"].Add(comment);
        }

        // print results
        foreach (var student in students)
        {
            Console.WriteLine(student.Key);

            // print comments
            Console.WriteLine("Comments:");
            foreach (var comment in student.Value["comments"])
            {
                Console.WriteLine($"- {comment}");
            }

            // print dates sorted
            student.Value["dates"].Sort();
            Console.WriteLine("Dates attended:");
            foreach (var date in student.Value["dates"])
            {
                Console.WriteLine($"-- {date}");
            }
        }
    }
}
