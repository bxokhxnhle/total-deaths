using System;
using static System.Console;

namespace Bme121
{
    class CauseOfDeathInfo
    {
        public string causeOfDeath;
        public string yearOfDeath;
        public string ageRangeOfDeath;
        public string sex;
        public int numberOfDeaths;
        public double percentOfTotalDeaths;
        public double mortality;
        
        public CauseOfDeathInfo(string causeOfDeath, string yearOfDeath, string ageRangeOfDeath, 
            string sex, int numberOfDeaths, double percentOfTotalDeaths, double mortality)
        {
            this.causeOfDeath = causeOfDeath;
            this.yearOfDeath = yearOfDeath;
            this.ageRangeOfDeath = ageRangeOfDeath;
            this.sex = sex;
            this.numberOfDeaths = numberOfDeaths;
            this.percentOfTotalDeaths = percentOfTotalDeaths;
            this.mortality = mortality;
        }
    }
    static partial class Program
    {
        static void Main( )
        {
            // Load the array of CauseOfDeathInfo objects.
            CauseOfDeathInfo[ ] stats = MakeStatsArray( );
            WriteLine( "stats.Length={0}", stats.Length );
            
            // count number of deaths
            int count1 = 0;
            for (int i = 0; i < stats.Length; i++)
            {
                if (stats[i].causeOfDeath == "Salmonella infections" && stats[i].numberOfDeaths != 0)
                count1 = count1 + stats[i].numberOfDeaths;
            }
            
            WriteLine("Total deaths due to Salmonella infections in 2009 to 2018 are {0}", count1);
            
            // count number of deaths
            int count2 = 0;
            for (int i = 0; i < stats.Length; i++)
            {
                if (stats[i].yearOfDeath == "2017" && stats[i].ageRangeOfDeath == "15-24 years")
                count2 = count2 + stats[i].numberOfDeaths;
            }
            
            WriteLine("Total deaths for 2017 in the 15-24 years age range are {0}", count2);
        }
    }
}
