using System;
using System.Collections.Generic;
using System.Text;

namespace FFJob_For_real
{
    class Job
    {

        public string Jobname;
        public int Level;
        public int Experience;
        public int CurrentHP;
        public int MaxHP;

        public Job() 
        {
            Jobname = "Recruit";
            Level = 1;
            Experience = 0;
            MaxHP = 100;
            CurrentHP = 100;
        
        }
        public Job(string Jobname, int Level, int Experience, int CurrentHP, int MaxHP)
        {
            this.Jobname = Jobname;
            this.Level = Level;
            this.Experience = Experience;
            this.CurrentHP =CurrentHP;
            this.MaxHP = MaxHP;




        }
        public void DisplayJobInfo()
        {

            Console.WriteLine("Job:" + Jobname);
            Console.WriteLine("Level:" + Level);
            Console.WriteLine("Experience:" + Experience);
            Console.WriteLine("Current Health:" + CurrentHP);
            Console.WriteLine("Max Health:" + MaxHP);



        }
        public void GainExperience(int expGained)
        {
            Experience = expGained + Experience;
            if (Experience >= 100)
            {

                int levelsGained = Experience / 100;
                int extraExperience = Experience % 100;
                Experience = extraExperience;
                Level = Level + levelsGained;
                //Level += 1;  Same thing as above

            }

        }
        public void GainHP(int plusHP)
        {
            CurrentHP += plusHP;
            if (CurrentHP > MaxHP)
            {
                CurrentHP = MaxHP;
            }

        }
        public void LoseHp(int subtractHP)
        {
            CurrentHP -= subtractHP;
            if (CurrentHP < 0)
            {
                CurrentHP = 0;
            }


        }
    }


}
