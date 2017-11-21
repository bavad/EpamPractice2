using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            SoccerPlayer p1 = new SoccerPlayer("Petrov", 21);
            SoccerPlayer p2 = new SoccerPlayer("Ivanov", 18);
            SoccerPlayer p3 = new SoccerPlayer("Sidorov", 24);
            SoccerPlayer p4 = new SoccerPlayer("Andreyev", 30);
            Coach c1 = new Coach("Zidan");
            Coach c2 = new Coach("Manchini");
            Judge j = new Judge("Smith");
            Team t1 = new Team("Real Madrid", c1);
            Team t2 = new Team("Manchester City", c2);
            t1.AddPlayer(p1);
            t1.AddPlayer(p2);

            t2.AddPlayer(p3);
            t2.AddPlayer(p4);

            Play p = new Play(t1, t2, j);
            p.Goal += p.GoalHandler;

            p.Result();

            Console.WriteLine("Game start");
            p.OnGoal(t1);
            p.OnGoal(t2);
            p.OnGoal(t2);
            Console.WriteLine("Game finish");                 
            
            p.ActualResult();          


        }
        
    }
}
