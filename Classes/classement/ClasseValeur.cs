using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public class Valeurs
    {
        //D�finitions des variables :
        private int nbPoints;
        private int valeur;

        //M�thodes getteurs :
        public int getnbPoints()
        {
            return this.nbPoints;
        }
        public int getvaleur()
        {
            return this.valeur;
        }

        //M�thodes setteurs :
        void setnbPoints(int nbPoints)
        {
            this.nbPoints = nbPoints;
        }
        void setvaleur(int valeur)
        {
            this.valeur = valeur;
        }

        //M�thode toString :
        public string tostring()
        {
            return "La valeur du nombre de points est : " + this.nbPoints + "\nLa valeur est de : " + this.valeur;
        }
    }
}