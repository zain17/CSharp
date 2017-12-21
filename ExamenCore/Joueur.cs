using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCore
{
    class Joueur
    {
        /*
         *  Champs
         */
        private int noteGlobal;
        private int nbBut;
        private int nbDuel;
        private Championnat champ;
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
        /*
         * Méthodes
         */
    }
}
