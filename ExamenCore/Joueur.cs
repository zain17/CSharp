using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCore
{
    public class Joueur    
    {

        /*
         *  Champs
         */
        private string nom;
        private int noteGlobal;
        private int nbBut;
        private int nbDuel;
        private Championnat champ;
        public Joueur() { }
        public Joueur(string nom, int noteGlobal, Championnat champ)
        {
            this.noteGlobal = noteGlobal;
            this.champ = champ;
            this.nom = nom;
        }
        public Joueur(string nom, int noteGlobal, int nbBut, int nbDuel, Championnat champ)
        {
            this.noteGlobal = noteGlobal;
            this.nbBut = nbBut;
            this.nbDuel = nbDuel;
            this.champ = champ;
            this.nom = nom;
        }

        /*
         *  Propriétés
         */
        public int NoteGlobal
        {
            get
            {
                return noteGlobal;
            }

            set
            {
                noteGlobal = value;
            }
        }

        public int NbBut
        {
            get
            {
                return nbBut;
            }

            set
            {
                nbBut = value;
            }
        }

        public int NbDuel
        {
            get
            {
                return nbDuel;
            }

            set
            {
                nbDuel = value;
            }
        }

        internal Championnat Champ
        {
            get
            {
                return champ;
            }

            set
            {
                champ = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        /*
         * Méthodes
         */
        public override string ToString()
        {
            return "Joueur:{"+
                "nom:"+nom+","+
                "note global :" + noteGlobal + "," +
                "nombre des buts:" + nbBut + "," +
                "nombre des duels:" + nbDuel + "," +
                "championnat:" + champ + "," +
                "}";
        }
    }
}
