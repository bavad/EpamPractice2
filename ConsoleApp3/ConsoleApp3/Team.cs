using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Team
    {
        public string Name;
        public List<SoccerPlayer> Members;
        public Coach Coach;
        public double Level;

        public Team(string name, Coach coach)
        {
            Name = name;
            Members = new List<SoccerPlayer>();
            Coach = coach;
            Level = 0;           

        }

        public void AddPlayer(SoccerPlayer player)
        {
            Members.Add(player);
            Level += player.PlayLevel * Coach.Luck;
        }

        public void ShowTeam()
        {
            foreach (SoccerPlayer p in Members)
            {
                Console.WriteLine(p.Surname + " " + p.Age + " " + p.PlayLevel);
            }
        }

        public void SortTeam()
        {
            Members.Sort((a, b) => a.PlayLevel.CompareTo(b.PlayLevel) * -1);
        }

    }
}
