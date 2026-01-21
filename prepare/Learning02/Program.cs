/*
Design the Classes
You program should contain two classes one for a Job and one for the Resume itself, as follows:

Class: Job
Responsibilities:
Keeps track of the company, job title, start year, and end year.
Behaviors:
Displays the job information in the format "Job Title (Company) StartYear-EndYear", for example: "Software Engineer (Microsoft) 2019-2022".
Class: Resume
Responsibilities:
Keeps track of the person's name and a list of their jobs.
Behaviors:
Displays the resume, which shows the name first, followed by displaying each one of the jobs.
Based on these descriptions, you could create class diagrams like the following:
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        // Create a new job instance named job1
        Job job1 = new Job();

        // Set the member variables
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft"; // Example company

        //Example years
        job1._startYear = 2022;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "Data Analyst";
        job2._company = "OpenAI";

        // Check if they work
        job1.Display();
        job2.Display();

        Resume myResume = new Resume();

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }

    

}