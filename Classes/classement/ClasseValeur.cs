using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasseValeurs
{
    public class Valeurs
    {
        //Définitions des variables :
        private int nbPoints;
        private string valeur;

        //Méthodes getteurs :
        public getnbPoints()
        {
            return this.nbPoints;
        }
        public getvaleur()
        {
            return this.valeur;
        }

        //Méthodes setteurs :
        public setnbPoints(int nbPoints)
        {
            this.nbPoints = nbPoints;
        }
        public setvaleur(int valeur)
        {
            this.valeur = valeur;
        }

        //Méthode toString :
        public string toString()
        {
            return "La valeur du nombre de points est : " + this.nbPoints + "\nLa valeur est de : " + this.valeur;
        }
    }
}