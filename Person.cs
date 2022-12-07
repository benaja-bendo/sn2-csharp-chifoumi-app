using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        protected int Choix { get; private set; }

        protected string Nom { get; init; }
        public Person(string nom)
        {
            Nom = nom;
        }

        protected void Jouer(int choix)
        {
            this.Choix = choix;
        }
    }
}
