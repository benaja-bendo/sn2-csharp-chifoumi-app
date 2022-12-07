using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Joueur
    {
        public string Nom { get; init; }
        public int Choix { get; private set; }
        public Joueur(string nom)
        {
            Nom = nom;       
        }

        public void Jouer()
        {
            Choix = Int16.Parse(Console.ReadLine());
        }
    }
}
