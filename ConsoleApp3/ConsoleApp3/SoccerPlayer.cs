using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class SoccerPlayer
    {
        public string Surname;
        public int Age;
        public int PlayLevel;

        public SoccerPlayer(string surname, int age)
        {
            Surname = surname;
            Age = age;
            Random random = new Random();
            PlayLevel = random.Next(0, 101);
            Thread.Sleep(18);
        }
    }
}
