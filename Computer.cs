using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Computer
    {
        public int Choix { get;private set; }
        public Computer()
        {
            Choix = 0;
        }
        public void Jouer()
        {
            Random rnd = new Random();
            Choix = rnd.Next(0, 3);
        }
    }
}
