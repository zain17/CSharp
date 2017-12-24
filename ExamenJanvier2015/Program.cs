using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenCore;

namespace ExamenJanvier2015
{
    class Program
    {
        static void Main(string[] args)
        {
            GestionJoeurs g = new GestionJoeurs();
            Joueur joueur1 = new Joueur("Lionel Messi", 90, Championnat.Espagne);
            Joueur joueur2 = new Joueur("Cristiano Ronaldo", 90, Championnat.Espagne);
            Joueur joueur3 = new Joueur("Zlatan Ibrahimovic", 82, Championnat.France);
            Joueur joueur4 = new Joueur("Aymen Abdenour", 90, Championnat.Espagne);
            Joueur joueur5 = new Joueur("Jamie Vardy", 70, Championnat.Espagne);
            Joueur joueur6 = new Joueur("Gianluigi Buffon", 50, Championnat.Italie);
            /*Partie3*/
            /*
             * a
             */
            g.AjouterJoueur(joueur1);
            g.AjouterJoueur(joueur2);
            g.AjouterJoueur(joueur3);
            g.AjouterJoueur(joueur4);
            g.AjouterJoueur(joueur5);
            g.AjouterJoueur(joueur6);
            /*
             * b
             */
            List<Joueur> joueurs=g.SelectionnerNomines();
            Console.Out.WriteLine("\nAfficher la liste des Joueurs classée par score\n");
            (joueurs.OrderBy(x => x.NoteGlobal).ToList<Joueur>()).ForEach(x=>Console.Out.WriteLine(x));
            /*
             * c
             */

            Console.ReadKey();

        }
    }
}
