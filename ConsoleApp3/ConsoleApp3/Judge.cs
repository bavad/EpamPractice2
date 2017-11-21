using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Judge
    {
        public string Surname;
        public int Privilege;

        public Judge(string surname)
        {
            Surname = surname;
            Random random = new Random();
            Privilege = random.Next(0, 3);
            Thread.Sleep(18);
        }
    }
}
