using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCore
{
    public static class ExJoueur 
    {
        public static Joueur BonusJoueur(this Joueur joueur)
        {
            if(joueur.Champ.Equals(Championnat.Angleterren) | joueur.Champ.Equals(Championnat.Espagne)) 
                 joueur.NoteGlobal += 20 ;
            return joueur;
        }
    }
}
