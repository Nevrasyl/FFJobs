using System;
using System.Collections.Generic;

namespace FFJob_For_real
{
    class FFJobExample
    {

        static void Main(string[] args)
        {
            Job job1 = new Job("Dancer", 1, 44, 50, 100);
           /* job1.Level = 1;
            job1.Experience = 44;*/
            job1.GainExperience(6);
           /* job1.CurrentHP = 50;
            job1.MaxHP = 100;*/
            job1.GainHP(20);


            Job job2 = new Job("Bard", 15, 99, 10, 1000);
            /*((job2.Level = 15;
            job2.Experience = 99;*/
            job2.GainExperience(400);
            /*job2.CurrentHP = 10;
            job2.MaxHP = 1000;*/
            job2.LoseHp(30);

            int[] array;
            array = new int[14];
            array = new int[3] {1, 2, 3};
            Job[] JobArray = new Job[2];
            JobArray[0] = job1;
            JobArray[1] = job2;

            List<Job> JobList = new List<Job>();
            JobList.Add(job1);
            JobList.Add(job2);

            job2.Jobname = "Bard";

            Character chara = new Character();
            chara.Name = "Biggun";
            chara.Jobs.Add(job1);
            chara.Jobs.Add(job2);


            chara.Jobs[0].DisplayJobInfo();
            Console.WriteLine();
            chara.Jobs[1].DisplayJobInfo();



        }
    }
}
