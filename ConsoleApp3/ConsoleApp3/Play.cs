using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    
    class Play
    {
        public Team Team1;
        public Team Team2;
        public Judge Judge;        
        public int FirstScore;
        public int SecondScore;

        public delegate void PlayHandler(Team t);
        public event PlayHandler Goal;
        public Play(Team team1, Team team2, Judge judje)
        {
            Team1 = team1;
            Team2 = team2;
            Judge = judje;            
        }


        public void OnGoal(Team t)
        {
            Goal(t);
        }

        public void GoalHandler(Team t)
        {
            Console.WriteLine(t.Name + " scores the goal");
            if (t.Name == Team1.Name)
            {
                FirstScore++;
            } else
            {
                SecondScore++;
            }
        }
        public void Result()
        {
            double firstLevel = Team1.Level, secondLevel = Team2.Level;
            if (Judge.Privilege == 1)
            {
                firstLevel *= 1.1;
            } else if (Judge.Privilege == 2)
            {
                secondLevel *= 1.1;
            }

            Console.WriteLine("Prognosis:");
            if (firstLevel  > 1.1 * secondLevel)
            {
                Console.WriteLine(Team1.Name + " defeated " + Team2.Name);
            } else if (secondLevel > 1.1 * firstLevel)
            {
                Console.WriteLine(Team2.Name + " defeated " + Team1.Name);
            } else
            {
                Console.WriteLine(Team1.Name + ", " + Team2.Name + " draw");
            }
        }
        public void ActualResult()
        {
            Console.WriteLine("Actual result:");
            Console.WriteLine(Team1.Name + " " + FirstScore + ":" + SecondScore + " " + Team2.Name);
            try
            {
                if ((Team1.Level > 1.1 * Team2.Level && SecondScore > FirstScore) ||
                    (Team2.Level > 1.1 * Team1.Level && FirstScore > SecondScore) ||
                    (Team2.Level < 1.1 * Team1.Level && Team1.Level < 1.1 * Team2.Level && FirstScore != SecondScore))
                {
                    throw new PrognosisException();
                }
            } catch(PrognosisException e)
            {
                Console.WriteLine(e);
            }
            
        }
        
    }
}
