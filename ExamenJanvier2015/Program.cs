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
            /*Partie3*/
            /*
             * a) Ajouter les joueurs mentionnés dans la figure 1
             */
            GestionJoeurs g = new GestionJoeurs();
            Joueur joueur1 = new Joueur("Lionel Messi", 90, Championnat.Espagne);
            Joueur joueur2 = new Joueur("Cristiano Ronaldo", 90, Championnat.Espagne);
            Joueur joueur3 = new Joueur("Zlatan Ibrahimovic", 82, Championnat.France);
            Joueur joueur4 = new Joueur("Aymen Abdenour", 90, Championnat.Espagne);
            Joueur joueur5 = new Joueur("Jamie Vardy", 70, Championnat.Espagne);
            Joueur joueur6 = new Joueur("Gianluigi Buffon", 50, Championnat.Italie);

            g.AjouterJoueur(joueur1);
            g.AjouterJoueur(joueur2);
            g.AjouterJoueur(joueur3);
            g.AjouterJoueur(joueur4);
            g.AjouterJoueur(joueur5);
            g.AjouterJoueur(joueur6);
            /*
             * b) Afficher la liste des Joueurs classée par score 
             */
            List<Joueur> joueurs = g.SelectionnerNomines();
            Console.Out.WriteLine("\nb) Afficher la liste des Joueurs classée par score \n");
            (joueurs.OrderBy(x => x.NoteGlobal).ToList<Joueur>()).ForEach(x => Console.Out.WriteLine(x));
            /*
             * c) Afficher la liste des Joueurs qui jouent en Espagne 
             */
            Console.WriteLine("\nc) Afficher la liste des Joueurs qui jouent en Espagne \n");
            ((joueurs.Where(x => x.Champ.Equals(Championnat.Espagne))).ToList<Joueur>()).ForEach(x => Console.WriteLine(x));
            /*
             * d) Supprimer le joueur Gianluigi Buffon
             */
            g.SupprimerJoueur(joueur6);
            /*
             * 10-b) Afficher les 3 meilleurs joueurs selon le nouveau score calculé
             */
            Console.WriteLine("\n10-b) Afficher les 3 meilleurs joueurs selon le nouveau score calculé\n");
            List<Joueur> joueursOverideScore = new List<Joueur>();
            joueurs.ForEach(x => joueursOverideScore.Add(x.BonusJoueur()));
            (joueursOverideScore.OrderByDescending(x => x.NoteGlobal).Take(3)).ToList<Joueur>().ForEach(x=>Console.WriteLine(x));               
            Console.ReadKey();
        }
    }
}
