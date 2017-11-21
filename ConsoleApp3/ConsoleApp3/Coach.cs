using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Coach
    {
        public string Surname;
        public double Luck;

        public Coach(string surname)
        {
            Surname = surname;
            Random random = new Random();
            Luck = (double)random.Next(5, 16) / 10;
            Thread.Sleep(18);
        }
    }
}
