using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Region
    {
        //Définitions des variables :
        private string nomRegion;

        //Méthodes getteurs :
        public string getNomRegion()
        {
            return nomRegion;
        }

        //Méthodes setteurs :
        public void setNomRegion(string nouveauNom)
        {
            this.nomRegion = nouveauNom;
        }

        public string tostring()
        {
            return("Le nom du Rôle est : " + nomRegion);
        }
    }
}