using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Enigineer";
        job1._companyName = "John's Software";
        job1._startYear = 2015;
        job1._endYear = 2025;
        
        Job job2 = new Job();
        job2._jobTitle = "Sales Person";
        job2._companyName = "Pete's PC's";
        job2._startYear = 2012;
        job2._endYear = 2015;

        Resume myResume = new Resume();
        myResume._name = "Anissa Pooley";
        
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();

    }
}