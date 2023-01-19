using System;

class Program
{
    static void Main(string[] args)
    {
        job job1 = new job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Samsung";
        job1._startYear = 1999;
        job1._endYear = 2012;
        job job2 = new job();
        job2._jobTitle = "Customer Support";
        job2._company = "Riot Games";
        job2._startYear = 2015;
        job2._endYear = 2023;
        Resume myResume = new Resume();
        myResume._name = "Jhon Burlington";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
    }
}