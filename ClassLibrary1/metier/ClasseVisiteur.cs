using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Visiteur
    {
        //attributs
        private string nomrole;


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