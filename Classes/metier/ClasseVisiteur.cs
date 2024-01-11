using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public class Visiteur
    {
        //attributs
        private string nomrôle;


        //methodes

        //Définitions des variables :
        private String nomRole;

        //Méthodes getteurs :

        public string getNomRôle()
        {
            return this.nomRole;
        }

        //Méthodes setteurs :
        public void setNomRole(string nouveauNom)
        {
            this.nomRole = nouveauNom;
        }

        public string tostring()
        {
            return("Le nom du Rôle est : " + this.nomRole);
        }
    }
}