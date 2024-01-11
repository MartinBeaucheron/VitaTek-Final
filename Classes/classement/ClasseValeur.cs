using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public class Valeurs
    {
        //Définitions des variables :
        private int nbPoints;
        private int valeur;

        //Méthodes getteurs :
        public int getnbPoints()
        {
            return this.nbPoints;
        }
        public int getvaleur()
        {
            return this.valeur;
        }

        //Méthodes setteurs :
        void setnbPoints(int nbPoints)
        {
            this.nbPoints = nbPoints;
        }
        void setvaleur(int valeur)
        {
            this.valeur = valeur;
        }

        //Méthode toString :
        public string tostring()
        {
            return "La valeur du nombre de points est : " + this.nbPoints + "\nLa valeur est de : " + this.valeur;
        }
    }
}