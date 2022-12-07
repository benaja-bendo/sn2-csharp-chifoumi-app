using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Game
    {
        private int[] Score { get; set; }
        private int Manche { get; set; }
        private Joueur Joueur { get; set; }
        private Computer Computer { get; set; }

        private string[] options = { "Pierre", "Papier", "Ciseaux" };
        public Game(Joueur joueur, Computer computer,int manche = 3)
        {
            Score = new int[] { 0, 0 };
            Manche = manche;
            Joueur = joueur;
            Computer = computer;
        }

        public void jouer()
        {
            while (Score.Max() < Manche)
            {
                Console.WriteLine($"C'est au tour de {Joueur.Nom} de jouer");
                Console.WriteLine("Pierre(0), Papier(1) ou Ciseaux(2) ? : ");
                Joueur.Jouer();

                Console.WriteLine("C'est au tour de l'ordinateur de jouer");
                Computer.Jouer();
                Console.WriteLine($"L'ordinateur a choisi {Computer.Choix}");

                Console.WriteLine($"vous avez choisi # {options[Joueur.Choix]} # et l'ordinateur a choisi # {options[Computer.Choix]} #");
                Score = comparerChoix(Joueur.Choix, Computer.Choix, Score);
                Console.WriteLine($"score {Score[0]} - {Score[1]}");
            }
            
            this.afficherResultat();
        }


        private int[] comparerChoix(int? choix1, int? choix2, int[] score)
        {
            if (choix1 == choix2)
            {
                Console.WriteLine("Egalité");
                return score;
            }
            else if (choix1 == 0 && choix2 == 2 || choix1 == 1 && choix2 == 0 || choix1 == 2 && choix2 == 1)
            {
                Console.WriteLine("Vous avez gagné");
                score[0]++;
                return score;
            }
            else
            {
                Console.WriteLine("Vous avez perdu");
                score[1]++;
                return score;
            }
        }
        private void afficherResultat()
        {
            Console.WriteLine("--------------------");
            if (Score[0] == 3)
            {
                Console.WriteLine("le gagnant est vous");
            }
            else
            {
                Console.WriteLine("le gagnant est l'ordinateur");
            }
            Console.WriteLine("--------------------");
        }
    }
}
