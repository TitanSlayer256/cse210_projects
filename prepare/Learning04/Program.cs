using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        MathAssignment hom1 = new MathAssignment("Micah", "Calculus", "7.2", "3");
        WritingAssignment hom2 = new WritingAssignment("Micah", "Stock Market", "The Crash of 2008");
        string answer = hom1.GetHomeworkList();
        string answer2 = hom2.GetWritingInformation();
        Console.WriteLine(answer);
        Console.WriteLine(answer2);
    }
}

public class Assignment
{
    private string _studentName;
    private string _topic;

   

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string name = GetStudentName();
        string topic = GetTopic();
        return $"{name}, {topic}, {_title}";
    }
}