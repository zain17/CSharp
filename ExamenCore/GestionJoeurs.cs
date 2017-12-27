using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCore
{
    public class GestionJoeurs
    {
        public List<Joueur> liste;

        public GestionJoeurs( )
        {
            this.liste = new List<Joueur>();
        }
        public void AjouterJoueur(Joueur j)
        {
            liste.Add(j);
        }
        public void SupprimerJoueur(Joueur j)
        {
            liste.Remove(j);
        }
        public void afficherJoueurParNom(string nomCible)
        {
            var joueur = from tt in liste
                         where tt.Nom.Equals(nomCible)
                         select tt;
            Console.Out.WriteLine(joueur);
        }
        public List<Joueur> SelectionnerNomines()
        {
            var nomines = from jou in liste  select jou;
            List<Joueur> joueurs = nomines.ToList<Joueur>();
            Console.WriteLine("\nSelectionnerNomines\n");
            (joueurs.OrderByDescending(x => x.NoteGlobal).Take(3)).ToList<Joueur>().ForEach(x => Console.Out.WriteLine(x));
            return joueurs;
        }

    }
}
